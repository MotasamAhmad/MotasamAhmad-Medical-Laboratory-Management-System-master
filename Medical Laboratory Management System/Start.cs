using System;

namespace Medical_Laboratory_Management_System
{
    public partial class Start
    {
        public Start()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                RectangleShape1.Width += 2;
                if (RectangleShape1.Width >= 298)
                {
                    Timer1.Stop();
                    My.MyProject.Forms.Login.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}