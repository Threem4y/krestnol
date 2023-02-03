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

namespace skorodyrarium
{

    public partial class MainWindow : Window
    {
        private bool vibro;
        private bool electric = false;
        public MainWindow()
        {
            InitializeComponent();

        }

        public int rand()
        {
            Random rnd = new Random();
            int u = rnd.Next(0, 8);
            return u;
        }
        public void main78()
        {
            Random rnd = new Random();
            int pencel = rnd.Next(1, 3);
            if (pencel == 1)
            {
                robot();
            }


        }
        public void bulba()
        {
            List<Button> spisok = new List<Button>() { GG, GG1, GG2, GG3, GG4, GG5, GG6, GG7, GG8 };
            if ((GG.Content == "X" && GG1.Content == "X" && GG2.Content == "X")
                || (GG3.Content == "X" && GG4.Content == "X" && GG5.Content == "X")
                || (GG6.Content == "X" && GG7.Content == "X" && GG8.Content == "X")
                || (GG.Content == "X" && GG3.Content == "X" && GG6.Content == "X")
                || (GG1.Content == "X" && GG4.Content == "X" && GG7.Content == "X")
                || (GG2.Content == "X" && GG5.Content == "X" && GG8.Content == "X")
                || (GG.Content == "X" && GG4.Content == "X" && GG8.Content == "X")
                || (GG2.Content == "X" && GG4.Content == "X" && GG6.Content == "X"))
            {
                for (int i = 0; i < spisok.Count; i++)
                {
                    spisok[i].IsEnabled = false;

                }
                NAG.Text = "X win";
                electric = true;
            }
            else if ((GG.Content == "O" && GG1.Content == "O" && GG2.Content == "O")
                || (GG3.Content == "O" && GG4.Content == "O" && GG5.Content == "O")
                || (GG6.Content == "O" && GG7.Content == "O" && GG8.Content == "O")
                || (GG.Content == "O" && GG3.Content == "O" && GG6.Content == "O")
                || (GG1.Content == "O" && GG4.Content == "O" && GG7.Content == "O")
                || (GG2.Content == "O" && GG5.Content == "O" && GG8.Content == "O")
                || (GG.Content == "O" && GG4.Content == "O" && GG8.Content == "O")
                || (GG2.Content == "O" && GG4.Content == "O" && GG6.Content == "O"))
            {
                for (int i = 0; i < spisok.Count; i++)
                {
                    spisok[i].IsEnabled = false;

                }
                NAG.Text = "O win";
                electric = true;
            }
            else if ((GG.IsEnabled == false) && (GG1.IsEnabled == false) 
                && (GG2.IsEnabled == false) && (GG3.IsEnabled == false) 
                && (GG4.IsEnabled == false) && (GG5.IsEnabled == false) 
                && (GG6.IsEnabled == false) && (GG7.IsEnabled == false) 
                && (GG8.IsEnabled == false)) 
            {
                for (int i = 0; i < spisok.Count; i++)
                {
                    spisok[i].IsEnabled = false;

                }
                NAG.Text = "Draw";
                electric = true;
            }

        }
        public void robot()
        {
            List<Button> spisok = new List<Button>() { GG, GG1, GG2, GG3, GG4, GG5, GG6, GG7, GG8 };
            for (int i = 0; i < spisok.Count; i++)
            {
                if (spisok[i].IsEnabled == false || spisok[i].Content.ToString() != "")
                {
                    spisok.RemoveAt(i);
                }
            }
            Random random = new Random();
            int r = 0;
            if (vibro == true)
            {
                if (spisok.Count > 0)
                {
                    while (true)
                    {
                        r = random.Next(0, spisok.Count - 1);
                        if (spisok[r].IsEnabled == false)
                        {
                            r = random.Next(0, spisok.Count - 1);
                        }
                        else
                            break;

                    }
                }
                else if (spisok.Count == 1)
                {
                    r = 0;

                }
                spisok[r].Content = "O";
                spisok[r].IsEnabled = false;
                bulba();

            }

        }




        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            List<Button> spisok = new List<Button> { GG, GG1, GG2, GG3, GG4, GG5, GG6, GG7, GG8 };
            foreach (Button button in spisok)
            {
                button.IsEnabled = true;
                button.Content = "";
                
            }
            electric = false;
        }

        private void GG_Click(object sender, RoutedEventArgs e)
        {
            GG.Content = "X";
            GG.IsEnabled = false;
            vibro = true;

            bulba();
            if (electric != true)
            {
                robot();
            }
            
        }

        private void GG1_Click(object sender, RoutedEventArgs e)
        {
            GG1.Content = "X";
            GG1.IsEnabled = false;
            vibro = true;
            bulba();
            if (electric != true)
            {
                robot();
            }

        }

        private void GG2_Click(object sender, RoutedEventArgs e)
        {
            GG2.Content = "X";
            GG2.IsEnabled = false;
            vibro = true;
            bulba();
            if (electric != true)
            {
                robot();
            }

        }

        private void GG3_Click(object sender, RoutedEventArgs e)
        {
            GG3.Content = "X";
            GG3.IsEnabled = false;
            vibro = true;
            bulba();
            if (electric != true)
            {
                robot();
            }

        }

        private void GG4_Click(object sender, RoutedEventArgs e)
        {
            GG4.Content = "X";
            vibro = true;
            GG4.IsEnabled = false;
            bulba();
            if (electric != true)
            {
                robot();
            }

        }

        private void GG5_Click(object sender, RoutedEventArgs e)
        {
            GG5.Content = "X";

            GG5.IsEnabled = false;
            vibro = true;
            bulba();
            if (electric != true)
            {
                robot();
            }

        }

        private void GG6_Click(object sender, RoutedEventArgs e)
        {
            GG6.Content = "X";
            GG6.IsEnabled = false;
            vibro = true;
            bulba();
            if (electric != true)
            {
                robot();
            }
 
        }

        private void GG7_Click(object sender, RoutedEventArgs e)
        {
            GG7.Content = "X";

            GG7.IsEnabled = false;
            vibro = true;
            bulba();
            if (electric != true)
            {
                robot();
            }

        }

        private void GG8_Click(object sender, RoutedEventArgs e)
        {
            GG8.Content = "X";
            GG8.IsEnabled = false;
            vibro = true;
            bulba();
            if (electric != true)
            {
                robot();
            }

        }
    }
}
