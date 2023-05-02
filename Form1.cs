namespace Hilos_de_Proceso
{
    public partial class Form1 : Form
    {
        private int timer1Counter = 1;
        private int timer1Direction = 1;

        private int timer2Counter = 1;
        private int timer2Direction = 1;

        private int timer3Counter = 1;
        private int timer3Direction = 1;

        public Form1()
        {
            InitializeComponent();
        }



        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            lbl1.Text = timer1Counter.ToString();
            timer1Counter += timer1Direction;

            if (timer1Counter >= 100 || timer1Counter <= 1)
            {
                timer1Direction *= -1;
            }
        }

        private void tmr2_Tick(object sender, EventArgs e)
        {
            lbl2.Text = timer2Counter.ToString();
            timer2Counter += timer2Direction;

            if (timer1Counter % 20 == 0)
            {
                timer2Direction *= -1;
            }

            if (timer2Counter < 1)
            {
                timer2Counter = 1;
            }
            else if (timer2Counter > 20)
            {
                timer2Counter = 20;
            }
        }

        private void tmr3_Tick(object sender, EventArgs e)
        {
            lbl3.Text = timer3Counter.ToString();
            timer3Counter += timer3Direction;

            if (timer1Counter % 50 == 0)
            {
                timer3Direction *= -1;
            }

            if (timer3Counter < 1)
            {
                timer3Counter = 1;
            }
            else if (timer3Counter > 50)
            {
                timer3Counter = 50;
            }
        }
    }
}