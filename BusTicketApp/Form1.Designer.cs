namespace BusTicketApp
{
    partial class BusTicketApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusTicketApp));
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBoxPassengerInformation = new GroupBox();
            buttonPassengerList = new Button();
            buttonPassengerGet = new Button();
            textBoxSeatNumber = new TextBox();
            radioButtonGenderFemale = new RadioButton();
            radioButtonGenderMale = new RadioButton();
            textBoxTelephoneNumber = new TextBox();
            textBoxPassengerSurname = new TextBox();
            textBoxPassengerName = new TextBox();
            dgwPassenger = new DataGridView();
            groupBoxPassengerInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwPassenger).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(16, 25);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(212, 569);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxPassengerInformation
            // 
            groupBoxPassengerInformation.Controls.Add(buttonPassengerList);
            groupBoxPassengerInformation.Controls.Add(buttonPassengerGet);
            groupBoxPassengerInformation.Controls.Add(textBoxSeatNumber);
            groupBoxPassengerInformation.Controls.Add(radioButtonGenderFemale);
            groupBoxPassengerInformation.Controls.Add(radioButtonGenderMale);
            groupBoxPassengerInformation.Controls.Add(textBoxTelephoneNumber);
            groupBoxPassengerInformation.Controls.Add(textBoxPassengerSurname);
            groupBoxPassengerInformation.Controls.Add(textBoxPassengerName);
            groupBoxPassengerInformation.Location = new Point(234, 25);
            groupBoxPassengerInformation.Margin = new Padding(3, 4, 3, 4);
            groupBoxPassengerInformation.Name = "groupBoxPassengerInformation";
            groupBoxPassengerInformation.Padding = new Padding(3, 4, 3, 4);
            groupBoxPassengerInformation.Size = new Size(343, 293);
            groupBoxPassengerInformation.TabIndex = 2;
            groupBoxPassengerInformation.TabStop = false;
            groupBoxPassengerInformation.Text = "PassengerInformation";
            // 
            // buttonPassengerList
            // 
            buttonPassengerList.Location = new Point(256, 255);
            buttonPassengerList.Margin = new Padding(3, 4, 3, 4);
            buttonPassengerList.Name = "buttonPassengerList";
            buttonPassengerList.Size = new Size(62, 31);
            buttonPassengerList.TabIndex = 7;
            buttonPassengerList.Text = "List";
            buttonPassengerList.UseVisualStyleBackColor = true;
            buttonPassengerList.Click += buttonPassengerList_Click;
            // 
            // buttonPassengerGet
            // 
            buttonPassengerGet.AutoEllipsis = true;
            buttonPassengerGet.Location = new Point(256, 220);
            buttonPassengerGet.Margin = new Padding(3, 4, 3, 4);
            buttonPassengerGet.Name = "buttonPassengerGet";
            buttonPassengerGet.Size = new Size(62, 31);
            buttonPassengerGet.TabIndex = 6;
            buttonPassengerGet.Text = "Get";
            buttonPassengerGet.UseVisualStyleBackColor = true;
            buttonPassengerGet.Click += buttonPassengerGet_Click;
            // 
            // textBoxSeatNumber
            // 
            textBoxSeatNumber.Location = new Point(130, 220);
            textBoxSeatNumber.Margin = new Padding(3, 4, 3, 4);
            textBoxSeatNumber.Name = "textBoxSeatNumber";
            textBoxSeatNumber.PlaceholderText = "Seat Number";
            textBoxSeatNumber.Size = new Size(94, 27);
            textBoxSeatNumber.TabIndex = 5;
            // 
            // radioButtonGenderFemale
            // 
            radioButtonGenderFemale.AutoSize = true;
            radioButtonGenderFemale.ForeColor = Color.DarkSalmon;
            radioButtonGenderFemale.Location = new Point(179, 184);
            radioButtonGenderFemale.Margin = new Padding(3, 4, 3, 4);
            radioButtonGenderFemale.Name = "radioButtonGenderFemale";
            radioButtonGenderFemale.Size = new Size(78, 24);
            radioButtonGenderFemale.TabIndex = 4;
            radioButtonGenderFemale.TabStop = true;
            radioButtonGenderFemale.Text = "Female";
            radioButtonGenderFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonGenderMale
            // 
            radioButtonGenderMale.AutoSize = true;
            radioButtonGenderMale.ForeColor = SystemColors.ActiveCaption;
            radioButtonGenderMale.Location = new Point(103, 184);
            radioButtonGenderMale.Margin = new Padding(3, 4, 3, 4);
            radioButtonGenderMale.Name = "radioButtonGenderMale";
            radioButtonGenderMale.Size = new Size(63, 24);
            radioButtonGenderMale.TabIndex = 3;
            radioButtonGenderMale.TabStop = true;
            radioButtonGenderMale.Text = "Male";
            radioButtonGenderMale.UseVisualStyleBackColor = true;
            // 
            // textBoxTelephoneNumber
            // 
            textBoxTelephoneNumber.Location = new Point(66, 135);
            textBoxTelephoneNumber.Margin = new Padding(3, 4, 3, 4);
            textBoxTelephoneNumber.Name = "textBoxTelephoneNumber";
            textBoxTelephoneNumber.PlaceholderText = "Telephone Number";
            textBoxTelephoneNumber.Size = new Size(247, 27);
            textBoxTelephoneNumber.TabIndex = 2;
            // 
            // textBoxPassengerSurname
            // 
            textBoxPassengerSurname.Location = new Point(66, 91);
            textBoxPassengerSurname.Margin = new Padding(3, 4, 3, 4);
            textBoxPassengerSurname.Name = "textBoxPassengerSurname";
            textBoxPassengerSurname.PlaceholderText = "Passenger Surname";
            textBoxPassengerSurname.Size = new Size(247, 27);
            textBoxPassengerSurname.TabIndex = 1;
            // 
            // textBoxPassengerName
            // 
            textBoxPassengerName.Location = new Point(66, 45);
            textBoxPassengerName.Margin = new Padding(3, 4, 3, 4);
            textBoxPassengerName.Name = "textBoxPassengerName";
            textBoxPassengerName.PlaceholderText = "Passenger Name";
            textBoxPassengerName.Size = new Size(247, 27);
            textBoxPassengerName.TabIndex = 0;
            // 
            // dgwPassenger
            // 
            dgwPassenger.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwPassenger.Location = new Point(583, 35);
            dgwPassenger.Name = "dgwPassenger";
            dgwPassenger.RowHeadersWidth = 51;
            dgwPassenger.RowTemplate.Height = 29;
            dgwPassenger.Size = new Size(554, 440);
            dgwPassenger.TabIndex = 3;
            // 
            // BusTicketApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 621);
            Controls.Add(dgwPassenger);
            Controls.Add(groupBoxPassengerInformation);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1167, 668);
            Name = "BusTicketApp";
            Text = "BusTicketApp";
            Load += Form1_Load;
            groupBoxPassengerInformation.ResumeLayout(false);
            groupBoxPassengerInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwPassenger).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        public GroupBox groupBoxPassengerInformation;
        private Button buttonPassengerList;
        public Button buttonPassengerGet;
        public TextBox textBoxSeatNumber;
        public RadioButton radioButtonGenderFemale;
        public RadioButton radioButtonGenderMale;
        public TextBox textBoxTelephoneNumber;
        public TextBox textBoxPassengerSurname;
        public TextBox textBoxPassengerName;
        private DataGridView dgwPassenger;
    }
}