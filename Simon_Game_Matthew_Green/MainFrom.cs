using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon_Game_Matthew_Green
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }
      
        private void SequenceCreator()
        {
            List<int> sequence = new List<int>();
            Random randomNum = new Random();

            int randomSequence = randomNum.Next(1, 5);
            sequence.Add(randomSequence);


            if (sequence.Count() > 0)
            {
                foreach (int number in sequence)
                {
                    Task.Delay(1000).Wait();
                    switch (number)
                    {
                        case 1:
                            btnBlue.BackColor = System.Drawing.Color.Blue;
                            Task.Delay(1000).Wait();
                            btnBlue.BackColor = System.Drawing.Color.RoyalBlue;

                            break;

                        case 2:
                            btnRed.BackColor = System.Drawing.Color.Red;
                            Task.Delay(1000).Wait();
                            btnRed.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
                            break;

                        case 3:
                            btnYellow.BackColor = System.Drawing.Color.Yellow;
                            Task.Delay(1000).Wait();
                            btnYellow.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                            break;

                        case 4:
                            btnGreen.BackColor = System.Drawing.Color.Lime;
                            Task.Delay(1000).Wait();
                            btnGreen.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                            break;
                    }
                }
            }

        }

       

        private void Button_Click(object sender, EventArgs e)
        {
            List<int> userSequence = new List<int>();
            Button UserInput = (Button)sender;
            bool gameStarted = false;

            
            switch (UserInput.Name)
            {
                case "btnStart":
                        gameStarted = true;
                        break;

                    case "btnBlue":
                    if(gameStarted == true)
                        {
                            btnBlue.BackColor = System.Drawing.Color.Blue;
                            Task.Delay(500).Wait();
                            btnBlue.BackColor = System.Drawing.Color.RoyalBlue;
                            
                        }
                    

                    break;

                case "btnRed":

                        if (gameStarted == true)
                        {
                            btnRed.BackColor = System.Drawing.Color.Red;
                            Task.Delay(500).Wait();
                            btnRed.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
                        }
              
                    break;

                case "btnYellow":
                        if (gameStarted == true)
                        {
                            btnYellow.BackColor = System.Drawing.Color.Yellow;
                            Task.Delay(500).Wait();
                            btnYellow.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                        }
                 
                    break;

                case "btnGreen":
                        if (gameStarted == true)
                        {
                            btnGreen.BackColor = System.Drawing.Color.Lime;
                            Task.Delay(500).Wait();
                            btnGreen.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
                        }

                  
                    break;
            }
        }
    }
}
