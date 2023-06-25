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
            flwPanelSeat = new FlowLayoutPanel();
            grpBoxPassengerInformation = new GroupBox();
            btnPassengerList = new Button();
            btnPassengerGet = new Button();
            txtBoxSeatNumber = new TextBox();
            radioButtonGenderFemale = new RadioButton();
            radioButtonGenderMale = new RadioButton();
            txtBoxPassengerSurname = new TextBox();
            txtBoxPassengerName = new TextBox();
            dgwPassenger = new DataGridView();
            mskBoxPhoneNumber = new MaskedTextBox();
            grpBoxPassengerInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwPassenger).BeginInit();
            SuspendLayout();
            // 
            // flwPanelSeat
            // 
            flwPanelSeat.Location = new Point(16, 25);
            flwPanelSeat.Name = "flwPanelSeat";
            flwPanelSeat.Size = new Size(212, 569);
            flwPanelSeat.TabIndex = 0;
            // 
            // grpBoxPassengerInformation
            // 
            grpBoxPassengerInformation.Controls.Add(mskBoxPhoneNumber);
            grpBoxPassengerInformation.Controls.Add(btnPassengerList);
            grpBoxPassengerInformation.Controls.Add(btnPassengerGet);
            grpBoxPassengerInformation.Controls.Add(txtBoxSeatNumber);
            grpBoxPassengerInformation.Controls.Add(radioButtonGenderFemale);
            grpBoxPassengerInformation.Controls.Add(radioButtonGenderMale);
            grpBoxPassengerInformation.Controls.Add(txtBoxPassengerSurname);
            grpBoxPassengerInformation.Controls.Add(txtBoxPassengerName);
            grpBoxPassengerInformation.Location = new Point(234, 25);
            grpBoxPassengerInformation.Margin = new Padding(3, 4, 3, 4);
            grpBoxPassengerInformation.Name = "grpBoxPassengerInformation";
            grpBoxPassengerInformation.Padding = new Padding(3, 4, 3, 4);
            grpBoxPassengerInformation.Size = new Size(343, 293);
            grpBoxPassengerInformation.TabIndex = 2;
            grpBoxPassengerInformation.TabStop = false;
            grpBoxPassengerInformation.Text = "PassengerInformation";
            // 
            // btnPassengerList
            // 
            btnPassengerList.Location = new Point(211, 254);
            btnPassengerList.Margin = new Padding(3, 4, 3, 4);
            btnPassengerList.Name = "btnPassengerList";
            btnPassengerList.Size = new Size(62, 31);
            btnPassengerList.TabIndex = 7;
            btnPassengerList.Text = "List";
            btnPassengerList.UseVisualStyleBackColor = true;
            btnPassengerList.Click += buttonPassengerList_Click;
            // 
            // btnPassengerGet
            // 
            btnPassengerGet.AutoEllipsis = true;
            btnPassengerGet.Location = new Point(211, 219);
            btnPassengerGet.Margin = new Padding(3, 4, 3, 4);
            btnPassengerGet.Name = "btnPassengerGet";
            btnPassengerGet.Size = new Size(62, 31);
            btnPassengerGet.TabIndex = 6;
            btnPassengerGet.Text = "Get";
            btnPassengerGet.UseVisualStyleBackColor = true;
            btnPassengerGet.Click += buttonPassengerGet_Click;
            // 
            // txtBoxSeatNumber
            // 
            txtBoxSeatNumber.Location = new Point(93, 220);
            txtBoxSeatNumber.Margin = new Padding(3, 4, 3, 4);
            txtBoxSeatNumber.Name = "txtBoxSeatNumber";
            txtBoxSeatNumber.PlaceholderText = "Seat Number";
            txtBoxSeatNumber.Size = new Size(94, 27);
            txtBoxSeatNumber.TabIndex = 5;
            // 
            // radioButtonGenderFemale
            // 
            radioButtonGenderFemale.AutoSize = true;
            radioButtonGenderFemale.ForeColor = Color.DarkSalmon;
            radioButtonGenderFemale.Location = new Point(142, 184);
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
            radioButtonGenderMale.Location = new Point(66, 184);
            radioButtonGenderMale.Margin = new Padding(3, 4, 3, 4);
            radioButtonGenderMale.Name = "radioButtonGenderMale";
            radioButtonGenderMale.Size = new Size(63, 24);
            radioButtonGenderMale.TabIndex = 3;
            radioButtonGenderMale.TabStop = true;
            radioButtonGenderMale.Text = "Male";
            radioButtonGenderMale.UseVisualStyleBackColor = true;
            // 
            // txtBoxPassengerSurname
            // 
            txtBoxPassengerSurname.Location = new Point(66, 91);
            txtBoxPassengerSurname.Margin = new Padding(3, 4, 3, 4);
            txtBoxPassengerSurname.Name = "txtBoxPassengerSurname";
            txtBoxPassengerSurname.PlaceholderText = "Passenger Surname";
            txtBoxPassengerSurname.Size = new Size(207, 27);
            txtBoxPassengerSurname.TabIndex = 1;
            // 
            // txtBoxPassengerName
            // 
            txtBoxPassengerName.Location = new Point(66, 45);
            txtBoxPassengerName.Margin = new Padding(3, 4, 3, 4);
            txtBoxPassengerName.Name = "txtBoxPassengerName";
            txtBoxPassengerName.PlaceholderText = "Passenger Name";
            txtBoxPassengerName.Size = new Size(207, 27);
            txtBoxPassengerName.TabIndex = 0;
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
            // mskBoxPhoneNumber
            // 
            mskBoxPhoneNumber.Location = new Point(66, 135);
            mskBoxPhoneNumber.Mask = "(999) 000-0000";
            mskBoxPhoneNumber.Name = "mskBoxPhoneNumber";
            mskBoxPhoneNumber.Size = new Size(207, 27);
            mskBoxPhoneNumber.TabIndex = 8;
            // 
            // BusTicketApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 621);
            Controls.Add(dgwPassenger);
            Controls.Add(grpBoxPassengerInformation);
            Controls.Add(flwPanelSeat);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1167, 668);
            Name = "BusTicketApp";
            Text = "BusTicketApp";
            Load += Form1_Load;
            grpBoxPassengerInformation.ResumeLayout(false);
            grpBoxPassengerInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwPassenger).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flwPanelSeat;
        public GroupBox grpBoxPassengerInformation;
        private Button btnPassengerList;
        public Button btnPassengerGet;
        public TextBox txtBoxSeatNumber;
        public RadioButton radioButtonGenderFemale;
        public RadioButton radioButtonGenderMale;
        public TextBox txtBoxPassengerSurname;
        public TextBox txtBoxPassengerName;
        private DataGridView dgwPassenger;
        private MaskedTextBox mskBoxPhoneNumber;
    }
}