namespace BoschSimulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSend = new Button();
            lstEvents = new ListBox();
            numAccount = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            numReceiver = new NumericUpDown();
            label3 = new Label();
            numPoint = new NumericUpDown();
            radRestore = new RadioButton();
            label4 = new Label();
            radEvent = new RadioButton();
            label5 = new Label();
            numArea = new NumericUpDown();
            label6 = new Label();
            txtEndPoint = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtDataSent = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)numAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReceiver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPoint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numArea).BeginInit();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(242, 409);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(120, 23);
            btnSend.TabIndex = 1;
            btnSend.Text = "Send Event";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // lstEvents
            // 
            lstEvents.FormattingEnabled = true;
            lstEvents.ItemHeight = 15;
            lstEvents.Location = new Point(12, 53);
            lstEvents.Name = "lstEvents";
            lstEvents.Size = new Size(224, 379);
            lstEvents.TabIndex = 2;
            // 
            // numAccount
            // 
            numAccount.Location = new Point(242, 97);
            numAccount.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numAccount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAccount.Name = "numAccount";
            numAccount.Size = new Size(120, 23);
            numAccount.TabIndex = 3;
            numAccount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 35);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 4;
            label1.Text = "Receiver #";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 79);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 5;
            label2.Text = "Account #";
            // 
            // numReceiver
            // 
            numReceiver.Location = new Point(242, 53);
            numReceiver.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numReceiver.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numReceiver.Name = "numReceiver";
            numReceiver.Size = new Size(120, 23);
            numReceiver.TabIndex = 6;
            numReceiver.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 167);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 8;
            label3.Text = "Point/User #";
            // 
            // numPoint
            // 
            numPoint.Location = new Point(242, 185);
            numPoint.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numPoint.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPoint.Name = "numPoint";
            numPoint.Size = new Size(120, 23);
            numPoint.TabIndex = 7;
            numPoint.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // radRestore
            // 
            radRestore.AutoSize = true;
            radRestore.Location = new Point(242, 259);
            radRestore.Name = "radRestore";
            radRestore.Size = new Size(67, 19);
            radRestore.TabIndex = 10;
            radRestore.Text = "Restoral";
            radRestore.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 35);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 11;
            label4.Text = "ContactID Code";
            // 
            // radEvent
            // 
            radEvent.AutoSize = true;
            radEvent.Checked = true;
            radEvent.Location = new Point(242, 234);
            radEvent.Name = "radEvent";
            radEvent.Size = new Size(54, 19);
            radEvent.TabIndex = 9;
            radEvent.TabStop = true;
            radEvent.Text = "Event";
            radEvent.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(242, 123);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 13;
            label5.Text = "Area #";
            // 
            // numArea
            // 
            numArea.Location = new Point(242, 141);
            numArea.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numArea.Name = "numArea";
            numArea.Size = new Size(120, 23);
            numArea.TabIndex = 12;
            numArea.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(242, 216);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 14;
            label6.Text = "Qualifier";
            // 
            // txtEndPoint
            // 
            txtEndPoint.Location = new Point(117, 6);
            txtEndPoint.Name = "txtEndPoint";
            txtEndPoint.Size = new Size(142, 23);
            txtEndPoint.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(99, 15);
            label8.TabIndex = 7;
            label8.Text = "Remote Endpoint";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(368, 35);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 16;
            label7.Text = "Data Sent";
            // 
            // txtDataSent
            // 
            txtDataSent.BackColor = SystemColors.Control;
            txtDataSent.Location = new Point(372, 54);
            txtDataSent.Name = "txtDataSent";
            txtDataSent.ReadOnly = true;
            txtDataSent.Size = new Size(646, 378);
            txtDataSent.TabIndex = 17;
            txtDataSent.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 443);
            Controls.Add(txtDataSent);
            Controls.Add(label7);
            Controls.Add(txtEndPoint);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(numArea);
            Controls.Add(label4);
            Controls.Add(radRestore);
            Controls.Add(radEvent);
            Controls.Add(label3);
            Controls.Add(numPoint);
            Controls.Add(numReceiver);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numAccount);
            Controls.Add(lstEvents);
            Controls.Add(btnSend);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bosch ContactID Simulator";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numReceiver).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPoint).EndInit();
            ((System.ComponentModel.ISupportInitialize)numArea).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSend;
        private ListBox lstEvents;
        private NumericUpDown numAccount;
        private Label label1;
        private Label label2;
        private NumericUpDown numReceiver;
        private Label label3;
        private NumericUpDown numPoint;
        private RadioButton radRestore;
        private Label label4;
        private RadioButton radEvent;
        private Label label5;
        private NumericUpDown numArea;
        private Label label6;
        private TextBox txtEndPoint;
        private Label label8;
        private Label label7;
        private RichTextBox txtDataSent;
    }
}