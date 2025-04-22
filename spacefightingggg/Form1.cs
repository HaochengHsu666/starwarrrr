namespace spacefightingggg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int firedirection = 0;
      List<PictureBox> zdlist = new List<PictureBox>(); 


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            pictureBox2.Visible = false;
            switch (e.KeyCode)
            {
                case Keys.Up:

                    pictureBox3.Image = Image.FromFile("tank1.gif");
                    pictureBox3.Top = pictureBox3.Top - 5;
                    pictureBox2.Top = pictureBox3.Top - 80;
                    pictureBox2.Left = pictureBox3.Left - 10;
                    firedirection = 1;
                    break;

                case Keys.Down:
                    pictureBox3.Image = Image.FromFile("tank3.gif");
                    pictureBox3.Top = pictureBox3.Top + 5;
                    pictureBox2.Top = pictureBox3.Top + 80;
                    pictureBox2.Left = pictureBox3.Left + 10;
                    firedirection = 2;
                    break;
                case Keys.Left:
                    pictureBox3.Image = Image.FromFile("tank4.gif");
                    pictureBox3.Left = pictureBox3.Left - 5;
                    pictureBox2.Top = pictureBox3.Top +10;
                    pictureBox2.Left = pictureBox3.Left - 50;
                    firedirection = 3;
                    break;
                case Keys.Right:
                    pictureBox3.Image = Image.FromFile("tank2.gif");
                    pictureBox3.Left = pictureBox3.Left + 5;
                    pictureBox2.Top = pictureBox3.Top +10;
                    pictureBox2.Left = pictureBox3.Left + 50;
                    firedirection = 4;
                    break;
                case Keys.Space:
                    pictureBox2.Visible = true;
                   
                    timer1.Enabled = true;
                    break;


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            timer1.Interval = 30;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                if (firedirection == 1)
                {


                    pictureBox2.Top -= 7;

                }
                if (firedirection == 2)
                {


                    pictureBox2.Top += 7;

                }
                if (firedirection == 3)
                {


                    pictureBox2.Left -= 7;

                }
                if (firedirection == 4)
                {


                    pictureBox2.Left += 7;

                }

            }
            
            


        }
    }
    
