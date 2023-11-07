using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static BoschSimulator.ContactID;

namespace BoschSimulator
{
    public partial class Form1 : Form
    {
        private UdpClient client;
        private int sequence = 0;
        private int line = 1;

        public Form1()
        {
            InitializeComponent();
            client = new UdpClient(7700);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstEvents.DataSource = new BindingSource(Codes().OrderBy(v => v.Value), null);
            lstEvents.DisplayMember = "Value";
            lstEvents.ValueMember = "Key";
            txtEndPoint.Text = Properties.Settings.Default.EndPoint;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int type = (int)lstEvents.SelectedValue;
            int receiver = (int)numReceiver.Value;
            int account = (int)numAccount.Value;
            int point = (int)numPoint.Value;
            int area = (int)numArea.Value;

            int qualifier = radEvent.Checked ? 1 : 3;

            SendMessage(receiver, account, qualifier, type, area, point);
        }

        private void SendMessage(int receiver, int account, int qualifier, int code, int area, int point)
        {
            // sample 058B1Ca45890101[#0621|18112201009];
            var message = $"a{sequence:0000}{receiver:00}{line:00}[#{account:0000}|18{(int)qualifier}{code:000}{area:00}{point:000}]";
            var crc = CalcCRC(message);
            var len = message.Length.ToString("X2");

            message = $"\n{crc}{len}{message}\r";

            byte[] bytes = Encoding.ASCII.GetBytes(message);

            var split = txtEndPoint.Text.Split(":");

            try
            {
                var ip = IPAddress.Parse(split[0]);
                var port = Int32.Parse(split[1]);
                var endpoint = new IPEndPoint(ip, port);
                client.Send(bytes, bytes.Count(), endpoint);
                sequence++;

                string qal = qualifier == 1 ? "Event" : "Restore";
                txtDataSent.AppendText($" {qal} - Panel:{account}, EventType:{(int)qualifier}{code}, Area:{area}, Point:{point}, Raw message:{message.Remove(0, 1)}");
                txtDataSent.ScrollToCaret();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private static string CalcCRC(string input)
        {
            uint CRC = 0;

            foreach (char ch in input)
            { CRC = CalcCRC(CRC, ch); };
            return CRC.ToString("X4");
        }

        private static uint CalcCRC(uint CRC, char ch)
        {
            long temp = Strings.AscW(ch);

            for (int i = 0; i <= 8; i++)
            {
                temp = (temp ^ (CRC & 1));
                CRC >>= 1;

                if ((temp & 1) != 0)
                    CRC = CRC ^ 0xA001;

                temp >>= 1;
            }

            return CRC;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.EndPoint = txtEndPoint.Text;
            Properties.Settings.Default.Save();
        }
    }
}