namespace gerisayim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }               
        private void Form1_Load_1(object sender, EventArgs e)
        {
            textBox1.Text = "hh:mm:ss";
            label2.Text = textBox1.Text;
            timer1.Interval = 1000;
        }
        bool x = true;
        private void timer1_Tick_1(object sender, EventArgs e)
        {                        
            while (x)
            {
                label2.Text = textBox1.Text;
                x = false;
            }                       
            string time = label2.Text;
            var Time = time.Split(':');
            bool result1 = Int32.TryParse(Time[0], out int h);
            bool result2 = Int32.TryParse(Time[1], out int m);
            bool result3 = Int32.TryParse(Time[2], out int s);

            int Hour = h;
            int Munite = m;
            int Secound = s;            
            
            if(result1==true && result2 == true && result3 == true) 
            {
                if (Secound > 0)
                {
                    Secound--;
                }
                if (Secound == 0)
                {
                    Munite--;
                    Secound = 60;
                }
                if (Munite < 0)
                {
                    Hour--;
                    Munite = 59;
                }

                if (Hour == 0 && Munite == 0 && Secound == -1)
                {
                    label2.Text = Hour.ToString() + ":" + Munite.ToString() + ":" + Secound.ToString();
                    MessageBox.Show("time is finish");
                    //Thread.Sleep(100000000);
                }

                label2.Text = Hour.ToString() + ":" + Munite.ToString() + ":" + Secound.ToString();

            }
            else
            {
                MessageBox.Show("Please, you can write true time side");
               // Thread.Sleep(100000000);

            }


        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }

        
    }
}