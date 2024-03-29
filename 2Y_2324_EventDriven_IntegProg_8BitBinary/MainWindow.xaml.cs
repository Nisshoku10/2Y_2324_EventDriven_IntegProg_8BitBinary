﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _2Y_2324_EventDriven_IntegProg_8BitBinary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _score = 0;
        DispatcherTimer _dt = null;
        Random _rnd = new Random();
        private int _round = 1;
        double _currentTime = 90;

        public MainWindow()
        {
            InitializeComponent();
            _dt = new DispatcherTimer();
            _dt.Tick += _dt_Tick;
            _dt.Interval = new TimeSpan(0, 0, 0, 1, 0);
            _dt.Start();
            tbConvNum.Text = _rnd.Next(0, 75).ToString();
            lbRoundCount.Content = _round;
        }

        #region Button Events
        private void btn128_Click(object sender, RoutedEventArgs e)
        {
            if (tbBin128.Text == "0")
            {
                tbBin128.Text = "1";
                btn128.Background = Brushes.Green;
            }
            else
            {
                tbBin128.Text = "0";
                btn128.Background = Brushes.Red;
            }
        }

        private void btn64_Click(object sender, RoutedEventArgs e)
        {
            if (tbBin64.Text == "0")
            {
                tbBin64.Text = "1";
                btn64.Background = Brushes.Green;
            }
            else
            {
                tbBin64.Text = "0";
                btn64.Background = Brushes.Red;
            }
        }

        private void btn32_Click(object sender, RoutedEventArgs e)
        {
            if (tbBin32.Text == "0")
            {
                tbBin32.Text = "1";
                btn32.Background = Brushes.Green;
            }
            else
            {
                tbBin32.Text = "0";
                btn32.Background = Brushes.Red;
            }
        }

        private void btn16_Click(object sender, RoutedEventArgs e)
        {
            if (tbBin16.Text == "0")
            {
                tbBin16.Text = "1";
                btn16.Background = Brushes.Green;
            }
            else
            {
                tbBin16.Text = "0";
                btn16.Background = Brushes.Red;
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (tbBin8.Text == "0")
            {
                tbBin8.Text = "1";
                btn8.Background = Brushes.Green;
            }
            else
            {
                tbBin8.Text = "0";
                btn8.Background = Brushes.Red;
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (tbBin4.Text == "0")
            {
                tbBin4.Text = "1";
                btn4.Background = Brushes.Green;
            }
            else
            {
                tbBin4.Text = "0";
                btn4.Background= Brushes.Red;
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (tbBin2.Text == "0")
            {
                tbBin2.Text = "1";
                btn2.Background = Brushes.Green;
            }
            else
            {
                tbBin2.Text = "0";
                btn2.Background= Brushes.Red;
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (tbBin1.Text == "0")
            {
                tbBin1.Text = "1";
                btn1.Background = Brushes.Green; 
            }
            else
            {
                tbBin1.Text = "0";
                btn1.Background= Brushes.Red;
            }
        }
        #endregion
        #region DispatcherTimerEvents
        private void _dt_Tick(object sender, EventArgs e)
        {

            int time = int.Parse(lbTimer.Content.ToString());

            if (time != 0)
            {
                time--;
                lbTimer.Content = time.ToString();
            }
            else
            {
                _dt.Stop();
            }
        }

        #endregion

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            int userAns = 0;
            if (tbBin1.Text == "1")
            {
                userAns = userAns + 1;
            }
            if (tbBin2.Text == "1")
            {
                userAns = userAns + 2;
            }
            if (tbBin4.Text == "1")
            {
                userAns = userAns + 4;
            }
            if (tbBin8.Text == "1")
            {
                userAns = userAns + 8;
            }
            if (tbBin16.Text == "1")
            {
                userAns = userAns + 16;
            }
            if (tbBin32.Text == "1")
            {
                userAns = userAns + 32;
            }
            if (tbBin64.Text == "1")
            {
                userAns = userAns + 64;
            }
            if (tbBin128.Text == "1")
            {
                userAns = userAns + 128;
            }

            if (userAns == int.Parse(tbConvNum.Text))
            {
                _score++;
                _round++;
                MessageBox.Show("Correct!");
                tbConvNum.Text = _rnd.Next(0, 75).ToString();
                lbScore.Content = _score;
                lbRoundCount.Content = _round;
                Reset();
                ResetTimer();
            }
            else
            {
                _score--;
                MessageBox.Show("Wrong! Try Again!");
                lbScore.Content = _score;
            }
        }

        private void ResetTimer()
        {
            _dt.Stop();
            _currentTime = _currentTime * 0.66;
            lbTimer.Content = (int)_currentTime;
            _dt.Start();
        }
        private bool isGameOver(string lbcontent)
        {
            if(_round != 10 || lbcontent != "0")
            {
                return false;
            }
            else
            {
                _dt.Stop();
            }
            return true;
        }
        #region Menu Items
        private void MainMenu_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
        private void Leaderboards_Click(object sender, RoutedEventArgs e)
        {
            Leaderboards lb = new Leaderboards();  
            lb.Show();
            this.Hide();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion
        private void Reset()
        {
            tbBin128.Text = "0";
            tbBin64.Text = "0";
            tbBin32.Text = "0";
            tbBin16.Text = "0";
            tbBin8.Text = "0";
            tbBin4.Text = "0";
            tbBin2.Text = "0";
            tbBin1.Text = "0";

            btn128.Background = Brushes.Red;
            btn64.Background = Brushes.Red;
            btn32.Background = Brushes.Red;
            btn16.Background = Brushes.Red;
            btn8.Background = Brushes.Red;
            btn4.Background = Brushes.Red;
            btn2.Background = Brushes.Red;
            btn1.Background = Brushes.Red;
        }
    }
}
