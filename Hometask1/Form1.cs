using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometask1
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        public Label timelabel { get; set; }
        public PictureBox Baku { get; set; }
        public PictureBox London
        {
            get; set;
        }
        public PictureBox Moscow { get; set; }


        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Start();
            Baku = new PictureBox();
            London = new PictureBox();
            Moscow = new PictureBox();
            Button bakubutton = new Button();
            bakubutton.Text = "Baku";
            bakubutton.Name = "bakubutton";
            bakubutton.Location = new Point(200, 450);
            bakubutton.Font = new Font("Times new Roman", 24, FontStyle.Italic);
            bakubutton.AutoSize = true;
            bakubutton.BackColor = Color.Aquamarine;
            this.Controls.Add(bakubutton);
            bakubutton.Click += Bakubutton_Click;
            Baku.Location = new Point(150, 70);
            Baku.ImageLocation = @"https://upload.wikimedia.org/wikipedia/commons/2/28/Montage_of_Baku_2019.jpg";
            Baku.SizeMode = PictureBoxSizeMode.StretchImage;
            Baku.Size = new Size(300, 300);
            Baku.Visible = false;
            this.Controls.Add(Baku);
            //=====================================================
            Button londonbutton = new Button();
            londonbutton.Text = "London";
            londonbutton.Name = "londonbutton";
            londonbutton.Location = new Point(400, 450);
            londonbutton.Font = new Font("Times new Roman", 24, FontStyle.Italic);
            londonbutton.AutoSize = true;
            londonbutton.BackColor = Color.Aquamarine;
            this.Controls.Add(londonbutton);
            londonbutton.Click += Londonbutton_Click;
            London.Location = new Point(300, 70);
            London.ImageLocation = @"https://images.marathontours.com/London-13.jpg?w892-h892-x0-y0-mw400-mh400";
            London.SizeMode = PictureBoxSizeMode.StretchImage;
            London.Size = new Size(300, 300);
            London.Visible = false;
            this.Controls.Add(London);

            //=====================================================
            Button moscowbutton = new Button();
            moscowbutton.Text = "Moscow";
            moscowbutton.Name = "moscowbutton";
            moscowbutton.Location = new Point(600, 450);
            moscowbutton.Font = new Font("Times new Roman", 24, FontStyle.Italic);
            moscowbutton.AutoSize = true;
            moscowbutton.BackColor = Color.Aquamarine;
            this.Controls.Add(moscowbutton);
            moscowbutton.Click += Moscowbutton_Click;
            Moscow.Location = new Point(450, 70);
            Moscow.ImageLocation = @"https://upload.wikimedia.org/wikipedia/commons/2/23/Spasskaya_Tower_and_the_St._Basil%27s_Cathedral.jpg";
            Moscow.SizeMode = PictureBoxSizeMode.StretchImage;
            Moscow.Size = new Size(300, 300);
            Moscow.Visible = false;
            this.Controls.Add(Moscow);



            //=========================================
            timelabel = new Label();
            timelabel.Text = $"Time : {DateTime.Now.ToShortTimeString()}";
            timelabel.AutoSize = true;
            timelabel.Font = new Font("Times new Roman", 40, FontStyle.Bold);
            timelabel.Location = new Point(275, 0);
            timelabel.BackColor = Color.Red;
            this.Controls.Add(timelabel);
        }

        private void Moscowbutton_Click(object sender, EventArgs e)
        {
            Baku.Visible = false;
            London.Visible = false;
            Moscow.Visible = true;
            timer.Tick += Timer_Tick2;
        }

        private void Timer_Tick2(object sender, EventArgs e)
        {
            DateTime MoscowTime = new DateTime();
            MoscowTime = DateTime.Now.AddHours(-1);
            timelabel.Text = $"Time : {MoscowTime.ToLongTimeString()}";
        }

        private void Londonbutton_Click(object sender, EventArgs e)
        {
            Baku.Visible = false;
            London.Visible = true;
            Moscow.Visible = false;
            timer.Tick += Timer_Tick1;
        }

        private void Timer_Tick1(object sender, EventArgs e)
        {
            DateTime LondonTime = new DateTime();
            LondonTime = DateTime.Now.AddHours(-4);
            timelabel.Text = $"Time : {LondonTime.ToLongTimeString()}";
        }

        private void Bakubutton_Click(object sender, EventArgs e)
        {
            Baku.Visible = true;
            London.Visible = false;
            Moscow.Visible = false;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timelabel.Text = $"Time : {DateTime.Now.ToLongTimeString()}";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X > 0 && e.X <= 350)
            {
                this.BackColor = Color.BlueViolet;
            }
            else if (e.X > 350 && e.X <= 650)
            {
                this.BackColor = Color.Aqua;
            }
            else if (e.X > 650 && e.X <= 1000)
            {
                this.BackColor = Color.LightSkyBlue;
            }
        }
    }
}
