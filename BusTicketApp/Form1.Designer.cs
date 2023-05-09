namespace BusTicketApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBoxPassengerInformation = new GroupBox();
            button1 = new Button();
            buttonPassengerGet = new Button();
            textBoxSeatNumber = new TextBox();
            radioButtonGenderFemale = new RadioButton();
            radioButtonGenderMale = new RadioButton();
            textBoxTelephoneNumber = new TextBox();
            textBoxPassengerSurname = new TextBox();
            textBoxPassengerName = new TextBox();
            dataGridView1 = new DataGridView();
            groupBoxPassengerInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(16, 25);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(173, 569);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxPassengerInformation
            // 
            groupBoxPassengerInformation.Controls.Add(button1);
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
            // button1
            // 
            button1.Location = new Point(256, 255);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(62, 31);
            button1.TabIndex = 7;
            button1.Text = "List";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(583, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(554, 440);
            dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 621);
            Controls.Add(dataGridView1);
            Controls.Add(groupBoxPassengerInformation);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1167, 668);
            Name = "Form1";
            Text = "BusTicketApp";
            Load += Form1_Load;
            groupBoxPassengerInformation.ResumeLayout(false);
            groupBoxPassengerInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        public GroupBox groupBoxPassengerInformation;
        private Button button1;
        public Button buttonPassengerGet;
        public TextBox textBoxSeatNumber;
        public RadioButton radioButtonGenderFemale;
        public RadioButton radioButtonGenderMale;
        public TextBox textBoxTelephoneNumber;
        public TextBox textBoxPassengerSurname;
        public TextBox textBoxPassengerName;
        private DataGridView dataGridView1;
    }
}