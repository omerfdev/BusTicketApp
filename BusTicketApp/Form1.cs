using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing;
using System.Windows.Forms;

namespace BusTicketApp
{
    public partial class BusTicketApp : Form
    {
        public BusTicketApp()
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
                btn.Margin = new Padding(2);
                btn.Tag = i;
                btn.Text = "" + i;
                btn.UseVisualStyleBackColor = true;
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += btn_Click;
                if (i % 2 == 0) { btn.Margin = new Padding(0, 2, 30, 0); }
                if (i == 54)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(60, 70);
                    lbl.Size = new Size(70, 34);
                    lbl.Text = "EXIT";
                    lbl.Font = new Font("Tobota", 15, FontStyle.Regular);
                    lbl.Tag = i;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.BorderStyle = BorderStyle.FixedSingle;
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
            Passenger p = new Passenger()
            {
                Name=textBoxPassengerName.Text,
                Surname=textBoxPassengerSurname.Text,
                TelephoneNumber=textBoxTelephoneNumber.Text,
                
            };
            if (radioButtonGenderMale.Checked == true)
            {
                p.PassengerGender = "Male"; flowLayoutPanel1.Controls[int.Parse(textBoxSeatNumber.Text) - 1].BackColor = Color.Blue; flowLayoutPanel1.Controls[int.Parse(textBoxSeatNumber.Text) - 1].BackgroundImage = Image.FromFile(@"C:\Users\omerf\source\repos\BusTicketApp\BusTicketApp\ico\Men.png"); flowLayoutPanel1.Controls[int.Parse(textBoxSeatNumber.Text) - 1].BackgroundImageLayout = ImageLayout.Stretch;
            }
            else { p.PassengerGender = "Female"; flowLayoutPanel1.Controls[int.Parse(textBoxSeatNumber.Text) - 1].BackColor = Color.Pink; flowLayoutPanel1.Controls[int.Parse(textBoxSeatNumber.Text) - 1].BackgroundImage = Image.FromFile(@"C:\Users\omerf\source\repos\BusTicketApp\BusTicketApp\ico\Woman.png"); flowLayoutPanel1.Controls[int.Parse(textBoxSeatNumber.Text) - 1].BackgroundImageLayout = ImageLayout.Stretch; }            
            writer.WriteLine($"{p.Name = textBoxPassengerName.Text};{p.Surname = textBoxPassengerSurname.Text};{p.TelephoneNumber = textBoxTelephoneNumber.Text};{p.PassengerGender};{p.ID} ");

            flowLayoutPanel1.Controls[int.Parse(textBoxSeatNumber.Text) - 1].Enabled = false;
            passengers.Add(p);
            dgwPassenger.DataSource = null;
            dgwPassenger.DataSource = passengers;
            writer.Close();
        }

        private void buttonPassengerList_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:\Passenger\p.txt");
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] passenger = line.Split(';');
                Passenger p = new Passenger();
                
                p.Name = passenger[0];
                p.Surname = passenger[1];
                p.TelephoneNumber = passenger[2];
                p.PassengerGender = passenger[3];
                passengers.Add(p);
            }
            dgwPassenger.DataSource = null;
            dgwPassenger.DataSource = passengers;
            reader.Close();
        }
    }
}