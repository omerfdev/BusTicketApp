using System.Windows.Forms;

namespace BusTicketApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Passenger> passengers = new List<Passenger>();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 55; i++)
            {
                Button btn = new Button();
                btn.Location = new Point(50, 70);
                btn.Size = new Size(34, 34);
                btn.Tag = i;
                btn.Text = "" + i;
                btn.UseVisualStyleBackColor = true;
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += btn_Click;
                if (i == 54)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(60, 70);
                    lbl.Size = new Size(70, 34);
                    lbl.Text = "EXIT";
                    lbl.Font = new Font("Tobota", 15, FontStyle.Regular);
                    lbl.Tag = i;
                    lbl.BackColor = Color.YellowGreen;
                    flowLayoutPanel1.Controls.Add(lbl);
                }

            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                textBoxSeatNumber.Text = btn.Tag.ToString();
            }
        }
        private void buttonPassengerGet_Click(object sender, EventArgs e)
        {

            Directory.CreateDirectory(@"C:\Passenger");
            StreamWriter writer = new StreamWriter(@"C:\Passenger\p.txt", true);
            Passenger p = new Passenger();
            if (radioButtonGenderMale.Checked == true)
            {
                p.PassengerGender = "Male";
            }
            else { p.PassengerGender = "Female"; }
            writer.WriteLine($"{p.ID = int.Parse(textBoxSeatNumber.Text)};{p.Name = textBoxPassengerName.Text};{p.Surname = textBoxPassengerSurname.Text};{p.TelephoneNumber = textBoxTelephoneNumber.Text};{p.PassengerGender}; ");
            flowLayoutPanel1.Controls[int.Parse(textBoxSeatNumber.Text) - 1].Enabled = false;
            if (radioButtonGenderMale.Checked == true) { flowLayoutPanel1.Controls[int.Parse(textBoxSeatNumber.Text) - 1].BackColor = Color.Blue; }
            else { flowLayoutPanel1.Controls[int.Parse(textBoxSeatNumber.Text) - 1].BackColor = Color.Pink; }
            passengers.Add(p);

            writer.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:\Passenger\p.txt");
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] passenger = line.Split(';');
                //listBoxPassenger.Items.Add(line);
                Passenger p = new Passenger();
                p.ID = int.Parse(passenger[0]);
                p.Name = passenger[1];
                p.Surname = passenger[2];
                p.TelephoneNumber = passenger[3];
                p.PassengerGender = passenger[4];
                passengers.Add(p);
            }
            reader.Close();
            dataGridView1.DataSource = passengers;
        }
    }
}