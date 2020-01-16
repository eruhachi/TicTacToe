using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace test3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        bool start2 = false;

        //start

            public void select()
        {
            if(selectNaught.Visibility == Visibility.Visible)
            {
                selectNaught.Visibility = Visibility.Hidden;
                selectCross.Visibility = Visibility.Visible;
                start2 = true;
            }else if(selectNaught.Visibility == Visibility.Hidden)
            {
                selectNaught.Visibility = Visibility.Visible;
                selectCross.Visibility = Visibility.Hidden;
                start2 = false;
            }



        }

        public void selectXO()
        {
            if(start2 == false)
            {
                turn = 1;
                start = true;
            }
            else
            {
                turn = 0;
                start = false;
            }

            
        }



        //select buttons
        private void left_Click(object sender, RoutedEventArgs e)
        {
            select();
        }

        private void right_Click(object sender, RoutedEventArgs e)
        {
            select();
        }


        //hides start screen when start is pressed
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            panel.Visibility = Visibility.Hidden;
            startButton.Visibility = Visibility.Hidden;
            startText.Visibility = Visibility.Hidden;
            selectCross.Visibility = Visibility.Hidden;
            selectNaught.Visibility = Visibility.Hidden;
            left.Visibility = Visibility.Hidden;
            right.Visibility = Visibility.Hidden;
            highlight1.Visibility = Visibility.Visible;
            selectXO();
        }


        //disabled everything when win/tie

        public void winState()
        {

            highlight1.Visibility = Visibility.Hidden;
            highlight2.Visibility = Visibility.Hidden;

            btn0_0.IsEnabled = false;
            btn1_0.IsEnabled = false;
            btn2_0.IsEnabled = false;
            btn3_1.IsEnabled = false;
            btn4_1.IsEnabled = false;
            btn5_1.IsEnabled = false;
            btn6_2.IsEnabled = false;
            btn7_2.IsEnabled = false;
            btn8_2.IsEnabled = false;

            string p1WinCounterS = p1win.ToString();
            string p2WinCounterS = p2win.ToString();

            p1WinCounter.Text = p1WinCounterS;
            p2WinCounter.Text = p2WinCounterS;

        }

        //text for p1 win, p2 win and tie

        public void CrossWin()
        {
            if(start == true)
            {
                outcome.Text = "Player 2 wins!";
                p2win++;
            }else if(start == false)
            {
                outcome.Text = "Player 1 wins!";
                p1win++;
            }

            winState();
  
        }

        public void NaughtWin()
        {
            if (start == true)
            {
                outcome.Text = "Player 1 wins!";
                p1win++;
            }
            else if (start == false)
            {
                outcome.Text = "Player 2 wins!";
                p2win++;
            }

            winState();

        }

        public void Tie()
        {
            outcome.Text = "Tie!";
            winState();
        }

        //all win conditions
        public void WinCheck()
        {
            //cross win conditions horizontal
            if(cross1.Visibility == Visibility.Visible && cross2.Visibility == Visibility.Visible && cross3.Visibility == Visibility.Visible)
            {
                CrossWin();
            }
            else if (cross4.Visibility == Visibility.Visible && cross5.Visibility == Visibility.Visible && cross6.Visibility == Visibility.Visible)
            {
                CrossWin();
            }
            else if(cross7.Visibility == Visibility.Visible && cross8.Visibility == Visibility.Visible && cross9.Visibility == Visibility.Visible)
            {
                CrossWin();
            }

            //cross win conditions vertical
            if (cross1.Visibility == Visibility.Visible && cross4.Visibility == Visibility.Visible && cross7.Visibility == Visibility.Visible)
            {
                CrossWin();
            }
            else if(cross2.Visibility == Visibility.Visible && cross5.Visibility == Visibility.Visible && cross8.Visibility == Visibility.Visible)
            {
                CrossWin();
            }
            else if(cross3.Visibility == Visibility.Visible && cross6.Visibility == Visibility.Visible && cross9.Visibility == Visibility.Visible)
            {
                CrossWin();
            }

            //cross win conditions diagonaly
            if (cross1.Visibility == Visibility.Visible && cross5.Visibility == Visibility.Visible && cross9.Visibility == Visibility.Visible)
            {
                CrossWin();
            }
            else if(cross3.Visibility == Visibility.Visible && cross5.Visibility == Visibility.Visible && cross7.Visibility == Visibility.Visible)
            {
                CrossWin();
            }

 


            //naught win conditions horizontal
            if (naught1.Visibility == Visibility.Visible && naught2.Visibility == Visibility.Visible && naught3.Visibility == Visibility.Visible)
            {
                NaughtWin();
            }
            else if(naught4.Visibility == Visibility.Visible && naught5.Visibility == Visibility.Visible && naught6.Visibility == Visibility.Visible)
            {
                NaughtWin();
            }
            else if(naught7.Visibility == Visibility.Visible && naught8.Visibility == Visibility.Visible && naught9.Visibility == Visibility.Visible)
            {
                NaughtWin();
            }




            //naught win conditions vertical
            if (naught1.Visibility == Visibility.Visible && naught4.Visibility == Visibility.Visible && naught7.Visibility == Visibility.Visible)
            {
                NaughtWin();
            }
            else if(naught2.Visibility == Visibility.Visible && naught5.Visibility == Visibility.Visible && naught8.Visibility == Visibility.Visible)
            {
                NaughtWin();
            }else if(naught3.Visibility == Visibility.Visible && naught6.Visibility == Visibility.Visible && naught9.Visibility == Visibility.Visible)
            {
                NaughtWin();
            }


            //naught win conditions diagonaly
            if (naught1.Visibility == Visibility.Visible && naught5.Visibility == Visibility.Visible && naught9.Visibility == Visibility.Visible)
            {
                NaughtWin();
            }
            else if (naught3.Visibility == Visibility.Visible && naught5.Visibility == Visibility.Visible && naught7.Visibility == Visibility.Visible)
            {
                NaughtWin();
            }else
            {
                if (turnCounter == 9)
                {
                    Tie();
                }
            }





        }
        //some global ints
        int turn = 1;
        int turnCounter = 0;
        int p1win = 0;
        int p2win = 0;
        bool start = false;
        

        
        //handles the highlight indicating the players turn
            public void playerTurn()
        {
                if (highlight1.Visibility == Visibility.Hidden)
                {
                    highlight1.Visibility = Visibility.Visible;
                    highlight2.Visibility = Visibility.Hidden;
                }
                else if (highlight1.Visibility == Visibility.Visible)
                {
                    highlight1.Visibility = Visibility.Hidden;
                    highlight2.Visibility = Visibility.Visible;
                }
            
   
        }


        //row 1

        private void btn0_0_Click(object sender, RoutedEventArgs e)
            {
                if (turn == 0)
                {
                    cross1.Visibility = Visibility.Visible;
                    turn++;
                }
                else if (turn == 1)
                {

                    naught1.Visibility = Visibility.Visible;
                    turn--;
                }
                btn0_0.IsEnabled = false;

            turnCounter++;
            playerTurn();
            WinCheck();
        }

            private void btn1_0_Click(object sender, RoutedEventArgs e)
            {
                if (turn == 0)
                {
                    cross2.Visibility = Visibility.Visible;
                    turn++;
                }
                else if (turn == 1)
                {
                    naught2.Visibility = Visibility.Visible;
                    turn--;
                }
                btn1_0.IsEnabled = false;
            turnCounter++;
            playerTurn();
            WinCheck();
        }

            private void btn2_0_Click(object sender, RoutedEventArgs e)
            {
                if (turn == 0)
                {
                    cross3.Visibility = Visibility.Visible;
                    turn++;
                }
                else if (turn == 1)
                {
                    naught3.Visibility = Visibility.Visible;
                    turn--;
                }
                btn2_0.IsEnabled = false;
            turnCounter++;
            playerTurn();
            WinCheck();
        }



            //row 2

            private void btn3_1_Click(object sender, RoutedEventArgs e)
            {
                if (turn == 0)
                {
                    cross4.Visibility = Visibility.Visible;
                    turn++;
                }
                else if (turn == 1)
                {
                    naught4.Visibility = Visibility.Visible;
                    turn--;
                }
                btn3_1.IsEnabled = false;
            turnCounter++;
            playerTurn();
            WinCheck();
        }

            private void btn4_1_Click(object sender, RoutedEventArgs e)
            {
                if (turn == 0)
                {
                    cross5.Visibility = Visibility.Visible;
                    turn++;
                }
                else if (turn == 1)
                {
                    naught5.Visibility = Visibility.Visible;
                    turn--;
                }
                btn4_1.IsEnabled = false;
            turnCounter++;
            playerTurn();
            WinCheck();
        }

            private void btn5_1_Click(object sender, RoutedEventArgs e)
            {
                if (turn == 0)
                {
                    cross6.Visibility = Visibility.Visible;
                    turn++;
                }
                else if (turn == 1)
                {
                    naught6.Visibility = Visibility.Visible;
                    turn--;
                }
                btn5_1.IsEnabled = false;
            turnCounter++;
            playerTurn();
            WinCheck();
        }


            //row 3

            private void btn6_2_Click(object sender, RoutedEventArgs e)
            {
                if (turn == 0)
                {
                    cross7.Visibility = Visibility.Visible;
                    turn++;
                }
                else if (turn == 1)
                {
                    naught7.Visibility = Visibility.Visible;
                    turn--;
                }
                btn6_2.IsEnabled = false;
            turnCounter++;
            playerTurn();
            WinCheck();
        }

            private void btn7_2_Click(object sender, RoutedEventArgs e)
            {
                if (turn == 0)
                {
                    cross8.Visibility = Visibility.Visible;
                    turn++;
                }
                else if (turn == 1)
                {
                    naught8.Visibility = Visibility.Visible;
                    turn--;
                }
                btn7_2.IsEnabled = false;
            turnCounter++;
            playerTurn();
            WinCheck();
        }

            private void btn8_2_Click(object sender, RoutedEventArgs e)
            {
                if (turn == 0)
                {
                    cross9.Visibility = Visibility.Visible;
                    turn++;
                }
                else if (turn == 1)
                {
                    naught9.Visibility = Visibility.Visible;
                    turn--;
                }
                btn8_2.IsEnabled = false;
            turnCounter++;
            playerTurn();
            WinCheck();
        }


        public void GameRestart()
        {

            if(start == false && turn == 1)
            {
                turn--;
            }else if(start == true && turn == 0)
            {
                turn++;
            }

            //enable buttons again

            btn0_0.IsEnabled = true;
            btn1_0.IsEnabled = true;
            btn2_0.IsEnabled = true;
            btn3_1.IsEnabled = true;
            btn4_1.IsEnabled = true;
            btn5_1.IsEnabled = true;
            btn6_2.IsEnabled = true;
            btn7_2.IsEnabled = true;
            btn8_2.IsEnabled = true;

            //hide crosses again

            cross1.Visibility = Visibility.Hidden;
            cross2.Visibility = Visibility.Hidden;
            cross3.Visibility = Visibility.Hidden;
            cross4.Visibility = Visibility.Hidden;
            cross5.Visibility = Visibility.Hidden;
            cross6.Visibility = Visibility.Hidden;
            cross7.Visibility = Visibility.Hidden;
            cross8.Visibility = Visibility.Hidden;
            cross9.Visibility = Visibility.Hidden;

            //hide naughts again

            naught1.Visibility = Visibility.Hidden;
            naught2.Visibility = Visibility.Hidden;
            naught3.Visibility = Visibility.Hidden;
            naught4.Visibility = Visibility.Hidden;
            naught5.Visibility = Visibility.Hidden;
            naught6.Visibility = Visibility.Hidden;
            naught7.Visibility = Visibility.Hidden;
            naught8.Visibility = Visibility.Hidden;
            naught9.Visibility = Visibility.Hidden;

            //starts at player 1

            highlight1.Visibility = Visibility.Visible;
            highlight2.Visibility = Visibility.Hidden;

            //resets outcome message

            outcome.Text = "";

            //resets turnCounter
            turnCounter = 0;

        }




        public void changeXO()
        {
            panel.Visibility = Visibility.Visible;
            startButton.Visibility = Visibility.Visible;
            startText.Visibility = Visibility.Visible;
            left.Visibility = Visibility.Visible;
            right.Visibility = Visibility.Visible;
            selectCross.Visibility = Visibility.Hidden;
            selectNaught.Visibility = Visibility.Visible;

            start = false;
            start2 = false;


            GameRestart();
    



        }


        //replay and exit

        private void change_Click(object sender, RoutedEventArgs e)
        {
            changeXO();
        }

        private void restart_Click(object sender, RoutedEventArgs e)
            {

            GameRestart();

        }

            private void exit_Click(object sender, RoutedEventArgs e)
            {
                System.Windows.Application.Current.Shutdown();
            }


    }
}
