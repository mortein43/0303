using System;
using System.Threading;
using System.Windows.Forms;
namespace _0303
{
    public partial class Form1 : Form
    {
        private Thread soundThread;
        private volatile bool stopSound;
        public Form1()
        {
            InitializeComponent();
        }
        private void PlaySound(int frequency, int duration)
        {
            Console.Beep(frequency, duration);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            stopSound = true;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

            int count = Convert.ToInt32(numericNumber.Value);
            int frequency = Convert.ToInt32(numericGz.Value);
            int duration = Convert.ToInt32(numericLong.Value);
            stopSound = false;
            soundThread = new Thread(() =>
            {
                for (int i = 0; i < count; i++)
                {

                    if (stopSound == false)
                    {
                        PlaySound(frequency, duration);
                    }

                }
            }
            );
            soundThread.Start();
        }
    }
}