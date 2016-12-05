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

namespace hoofdstuk6Oef2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int getal = 0;

        public MainWindow()
        {
            InitializeComponent();
            Grandma.Visibility = Visibility.Hidden;
            NOven.Visibility = Visibility.Hidden;
            XOven.Visibility = Visibility.Hidden;
            SpaceCookie.Visibility = Visibility.Hidden;
            LeaveShopButton.Visibility = Visibility.Hidden;
            GrandmaLabelCosts.Visibility = Visibility.Hidden;
            GrandmaLabelPlus.Visibility = Visibility.Hidden;
            GrandmaLevelLabel.Visibility = Visibility.Hidden;
            GrandmaLevelLabel2.Visibility = Visibility.Hidden;
            NewOvenLevelLabel.Visibility = Visibility.Hidden;
            NewOvenLevelLabel2.Visibility = Visibility.Hidden;
            NewOvenLabelCosts.Visibility = Visibility.Hidden;
            NewOvenLabelPlus.Visibility = Visibility.Hidden;
            SecondOvenLevelLabel.Visibility = Visibility.Hidden;
            SecondOvenLevelLabel2.Visibility = Visibility.Hidden;
            SecondOvenLabelCosts.Visibility = Visibility.Hidden;
            SecondOvenLabelPlus.Visibility = Visibility.Hidden;
            SpaceCookieLevelLabel.Visibility = Visibility.Hidden;
            SpaceCookieLevelLabel2.Visibility = Visibility.Hidden;
            SpaceCookieLabelCosts.Visibility = Visibility.Hidden;
            SpaceCookieLabelPlus.Visibility = Visibility.Hidden;

        }

        private void Cookie_MouseEnter(object sender, MouseEventArgs e)
        {
            Cookie.StrokeThickness = 3;
        }

        private void Cookie_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (getal < 50)
            {
                getal = getal + 1;
                AantalCookies.Content = getal;
            }
            else if (getal < 200 && getal >= 50)
            {
                getal = getal + 4;
                AantalCookies.Content = getal;
            }
            else if (getal < 500 && getal >= 200)
            {
                getal = getal + 10;
                AantalCookies.Content = getal;
            }
            else if (getal < 1000000 && getal >= 500)
            {
                getal = getal + 20;
                AantalCookies.Content = getal;
            }
        }

        private void Cookie_MouseLeave(object sender, MouseEventArgs e)
        {
            Cookie.StrokeThickness = 1;
        }

        private void EnterShopButton_Click(object sender, RoutedEventArgs e)
        {
            Grandma.Visibility = Visibility.Visible;
            NOven.Visibility = Visibility.Visible;
            XOven.Visibility = Visibility.Visible;
            SpaceCookie.Visibility = Visibility.Visible;
            LeaveShopButton.Visibility = Visibility.Visible;
            GrandmaLevelLabel.Visibility = Visibility.Visible;
            GrandmaLevelLabel2.Visibility = Visibility.Visible;
            NewOvenLevelLabel.Visibility = Visibility.Visible;
            NewOvenLevelLabel2.Visibility = Visibility.Visible;
            SecondOvenLevelLabel.Visibility = Visibility.Visible;
            SecondOvenLevelLabel2.Visibility = Visibility.Visible;
            SecondOvenLabelCosts.Visibility = Visibility.Hidden;
            SecondOvenLabelPlus.Visibility = Visibility.Hidden;
            SpaceCookieLevelLabel.Visibility = Visibility.Visible;
            SpaceCookieLevelLabel2.Visibility = Visibility.Visible;
            EnterShopButton.Content = "Shop";
        }

        private void LeaveShopButton_Click(object sender, RoutedEventArgs e)
        {
            EnterShopButton.Content = "Enter Shop";
            Grandma.Visibility = Visibility.Hidden;
            NOven.Visibility = Visibility.Hidden;
            XOven.Visibility = Visibility.Hidden;
            SpaceCookie.Visibility = Visibility.Hidden;
            LeaveShopButton.Visibility = Visibility.Hidden;
            GrandmaLevelLabel.Visibility = Visibility.Hidden;
            GrandmaLevelLabel2.Visibility = Visibility.Hidden;
            NewOvenLevelLabel.Visibility = Visibility.Hidden;
            NewOvenLevelLabel2.Visibility = Visibility.Hidden;
            SecondOvenLevelLabel.Visibility = Visibility.Hidden;
            SecondOvenLevelLabel2.Visibility = Visibility.Hidden;
            SpaceCookieLevelLabel.Visibility = Visibility.Hidden;
            SpaceCookieLevelLabel2.Visibility = Visibility.Hidden;
        }

        private void Grandma_MouseEnter(object sender, MouseEventArgs e)
        {
            GrandmaLabelCosts.Visibility = Visibility.Visible;
            GrandmaLabelPlus.Visibility = Visibility.Visible;
        }

        private void Grandma_MouseLeave(object sender, MouseEventArgs e)
        {
            GrandmaLabelCosts.Visibility = Visibility.Hidden;
            GrandmaLabelPlus.Visibility = Visibility.Hidden;
        }

        private void Grandma_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(AantalCookies.Content) > 50)
            {
                getal = Convert.ToInt32(AantalCookies.Content) - 50;
                AantalCookies.Content = getal;
                GrandmaLevelLabel2.Content = Convert.ToInt32(GrandmaLevelLabel2.Content) + 1;
            }
        }

        private void NOven_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(AantalCookies.Content) > 200)
            {
                getal = Convert.ToInt32(AantalCookies.Content) - 200;
                AantalCookies.Content = getal;
                NewOvenLevelLabel2.Content = Convert.ToInt32(NewOvenLevelLabel2.Content) + 1;
            }
        }

        private void XOven_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(AantalCookies.Content) > 500)
            {
                getal = Convert.ToInt32(AantalCookies.Content) - 500;
                AantalCookies.Content = getal;
                SecondOvenLevelLabel2.Content = Convert.ToInt32(SecondOvenLevelLabel2.Content) + 1;
            }
        }

        private void SpaceCookie_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(AantalCookies.Content) > 1000)
            {
                getal = Convert.ToInt32(AantalCookies.Content) - 1000;
                AantalCookies.Content = getal;
                SpaceCookieLevelLabel2.Content = Convert.ToInt32(SpaceCookieLevelLabel2.Content) + 1;
            }
        }

        private void NOven_MouseEnter(object sender, MouseEventArgs e)
        {
            NewOvenLabelCosts.Visibility = Visibility.Visible;
            NewOvenLabelPlus.Visibility = Visibility.Visible;
        }

        private void NOven_MouseLeave(object sender, MouseEventArgs e)
        {
            NewOvenLabelCosts.Visibility = Visibility.Hidden;
            NewOvenLabelPlus.Visibility = Visibility.Hidden;
        }

        private void XOven_MouseEnter(object sender, MouseEventArgs e)
        {
            SecondOvenLabelCosts.Visibility = Visibility.Visible;
            SecondOvenLabelPlus.Visibility = Visibility.Visible;
        }

        private void XOven_MouseLeave(object sender, MouseEventArgs e)
        {
            SecondOvenLabelCosts.Visibility = Visibility.Hidden;
            SecondOvenLabelPlus.Visibility = Visibility.Hidden;
        }

        private void SpaceCookie_MouseEnter(object sender, MouseEventArgs e)
        {
            SpaceCookieLabelCosts.Visibility = Visibility.Visible;
            SpaceCookieLabelPlus.Visibility = Visibility.Visible;
        }

        private void SpaceCookie_MouseLeave(object sender, MouseEventArgs e)
        {
            SpaceCookieLabelCosts.Visibility = Visibility.Hidden;
            SpaceCookieLabelPlus.Visibility = Visibility.Hidden;
        }
    }
}
