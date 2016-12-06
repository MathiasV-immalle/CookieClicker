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
            Bakerie.Visibility = Visibility.Hidden;
            CookiePlanet.Visibility = Visibility.Hidden;
            Cookieversium.Visibility = Visibility.Hidden;
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
            SpaceCookieTransformer.Visibility = Visibility.Hidden;
            NormalCookieTransformer.Visibility = Visibility.Hidden;
            BakerieLevelLabel.Visibility = Visibility.Hidden;
            BakerieLevelLabel2.Visibility = Visibility.Hidden;
            BakerieLabelCosts.Visibility = Visibility.Hidden;
            BakerieLabelPlus.Visibility = Visibility.Hidden;
            CookiePlanetLevelLabel.Visibility = Visibility.Hidden;
            CookiePlanetLevelLabel2.Visibility = Visibility.Hidden;
            CookiePlanetLabelCosts.Visibility = Visibility.Hidden;
            CookiePlanetLabelPlus.Visibility = Visibility.Hidden;
            CookieversiumLevelLabel.Visibility = Visibility.Hidden;
            CookieversiumLevelLabel2.Visibility = Visibility.Hidden;
            CookieversiumLabelCosts.Visibility = Visibility.Hidden;
            CookieversiumLabelPlus.Visibility = Visibility.Hidden;

        }

        // Cookie + Click
        //
        //

        private void Cookie_MouseEnter(object sender, MouseEventArgs e)
        {
            Cookie.StrokeThickness = 3;
        }

        private void Cookie_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            getal = getal + 1
            + Convert.ToInt32(GrandmaLevelLabel2.Content) * 2
            + Convert.ToInt32(NewOvenLevelLabel2.Content) * 10
            + Convert.ToInt32(SecondOvenLevelLabel2.Content) * 25
            + Convert.ToInt32(SpaceCookieLevelLabel2.Content) * 50
            + Convert.ToInt32(BakerieLevelLabel2.Content) * 75
            + Convert.ToInt32(CookiePlanetLevelLabel2.Content) * 100
            + Convert.ToInt32(CookieversiumLevelLabel2.Content) * 150
            ;
            AantalCookies.Content = getal;
        }

        private void Cookie_MouseLeave(object sender, MouseEventArgs e)
        {
            Cookie.StrokeThickness = 1;
        }

        // Visibility
        //
        //

        private void EnterShopButton_Click(object sender, RoutedEventArgs e)
        {
            EnterShopButton.Content = "Shop";
            Grandma.Visibility = Visibility.Visible;
            NOven.Visibility = Visibility.Visible;
            XOven.Visibility = Visibility.Visible;
            SpaceCookie.Visibility = Visibility.Visible;
            Bakerie.Visibility = Visibility.Visible;
            CookiePlanet.Visibility = Visibility.Visible;
            Cookieversium.Visibility = Visibility.Visible;
            LeaveShopButton.Visibility = Visibility.Visible;
            GrandmaLevelLabel.Visibility = Visibility.Visible;
            GrandmaLevelLabel2.Visibility = Visibility.Visible;
            NewOvenLevelLabel.Visibility = Visibility.Visible;
            NewOvenLevelLabel2.Visibility = Visibility.Visible;
            SecondOvenLevelLabel.Visibility = Visibility.Visible;
            SecondOvenLevelLabel2.Visibility = Visibility.Visible;
            SpaceCookieLevelLabel.Visibility = Visibility.Visible;
            SpaceCookieLevelLabel2.Visibility = Visibility.Visible;
            BakerieLevelLabel.Visibility = Visibility.Visible;
            BakerieLevelLabel2.Visibility = Visibility.Visible;
            CookiePlanetLevelLabel.Visibility = Visibility.Visible;
            CookiePlanetLevelLabel2.Visibility = Visibility.Visible;
            CookieversiumLevelLabel.Visibility = Visibility.Visible;
            CookieversiumLevelLabel2.Visibility = Visibility.Visible;
        }

        private void LeaveShopButton_Click(object sender, RoutedEventArgs e)
        {
            EnterShopButton.Content = "Enter Shop";
            Grandma.Visibility = Visibility.Hidden;
            NOven.Visibility = Visibility.Hidden;
            XOven.Visibility = Visibility.Hidden;
            SpaceCookie.Visibility = Visibility.Hidden;
            Bakerie.Visibility = Visibility.Hidden;
            CookiePlanet.Visibility = Visibility.Hidden;
            Cookieversium.Visibility = Visibility.Hidden;
            LeaveShopButton.Visibility = Visibility.Hidden;
            GrandmaLevelLabel.Visibility = Visibility.Hidden;
            GrandmaLevelLabel2.Visibility = Visibility.Hidden;
            NewOvenLevelLabel.Visibility = Visibility.Hidden;
            NewOvenLevelLabel2.Visibility = Visibility.Hidden;
            SecondOvenLevelLabel.Visibility = Visibility.Hidden;
            SecondOvenLevelLabel2.Visibility = Visibility.Hidden;
            SpaceCookieLevelLabel.Visibility = Visibility.Hidden;
            SpaceCookieLevelLabel2.Visibility = Visibility.Hidden;
            BakerieLevelLabel.Visibility = Visibility.Hidden;
            BakerieLevelLabel2.Visibility = Visibility.Hidden;
            CookiePlanetLevelLabel.Visibility = Visibility.Hidden;
            CookiePlanetLevelLabel2.Visibility = Visibility.Hidden;
            CookieversiumLevelLabel.Visibility = Visibility.Hidden;
            CookieversiumLevelLabel2.Visibility = Visibility.Hidden;
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

        private void CookiePlanet_MouseEnter(object sender, MouseEventArgs e)
        {
            CookiePlanetLabelCosts.Visibility = Visibility.Visible;
            CookiePlanetLabelPlus.Visibility = Visibility.Visible;
        }

        private void CookiePlanet_MouseLeave(object sender, MouseEventArgs e)
        {
            CookiePlanetLabelCosts.Visibility = Visibility.Hidden;
            CookiePlanetLabelPlus.Visibility = Visibility.Hidden;
        }

        private void Cookieversium_MouseEnter(object sender, MouseEventArgs e)
        {
            CookieversiumLabelCosts.Visibility = Visibility.Visible;
            CookieversiumLabelPlus.Visibility = Visibility.Visible;
        }

        private void Cookieversium_MouseLeave(object sender, MouseEventArgs e)
        {
            CookieversiumLabelCosts.Visibility = Visibility.Hidden;
            CookieversiumLabelPlus.Visibility = Visibility.Hidden;
        }


        private void Bakerie_MouseEnter(object sender, MouseEventArgs e)
        {
            BakerieLabelCosts.Visibility = Visibility.Visible;
            BakerieLabelPlus.Visibility = Visibility.Visible;
        }

        private void Bakerie_MouseLeave(object sender, MouseEventArgs e)
        {
            BakerieLabelCosts.Visibility = Visibility.Hidden;
            BakerieLabelPlus.Visibility = Visibility.Hidden;
        }

        // Shop
        //
        //

        private void Grandma_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(AantalCookies.Content) >= 50)
            {
                getal = Convert.ToInt32(AantalCookies.Content) - 50;
                AantalCookies.Content = getal;
                GrandmaLevelLabel2.Content = Convert.ToInt32(GrandmaLevelLabel2.Content) + 1;
            }
        }

        private void NOven_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(AantalCookies.Content) >= 200)
            {
                getal = Convert.ToInt32(AantalCookies.Content) - 200;
                AantalCookies.Content = getal;
                NewOvenLevelLabel2.Content = Convert.ToInt32(NewOvenLevelLabel2.Content) + 1;
            }
        }

        private void XOven_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(AantalCookies.Content) >= 500)
            {
                getal = Convert.ToInt32(AantalCookies.Content) - 500;
                AantalCookies.Content = getal;
                SecondOvenLevelLabel2.Content = Convert.ToInt32(SecondOvenLevelLabel2.Content) + 1;
            }
        }

        private void SpaceCookie_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(AantalCookies.Content) >= 1000)
            {
                getal = Convert.ToInt32(AantalCookies.Content) - 1000;
                AantalCookies.Content = getal;
                SpaceCookieLevelLabel2.Content = Convert.ToInt32(SpaceCookieLevelLabel2.Content) + 1;
                SpaceCookieTransformer.Visibility = Visibility.Visible;
                NormalCookieTransformer.Visibility = Visibility.Visible;
            }
        }

        private void Bakerie_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(AantalCookies.Content) >= 3000)
            {
                getal = Convert.ToInt32(AantalCookies.Content) - 3000;
                AantalCookies.Content = getal;
                BakerieLevelLabel2.Content = Convert.ToInt32(BakerieLevelLabel2.Content) + 1;
            }
        }

        private void CookiePlanet_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(AantalCookies.Content) >= 5000)
            {
                getal = Convert.ToInt32(AantalCookies.Content) - 5000;
                AantalCookies.Content = getal;
                CookiePlanetLevelLabel2.Content = Convert.ToInt32(CookiePlanetLevelLabel2.Content) + 1;
            }
        }

        private void Cookieversium_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(AantalCookies.Content) >= 10000)
            {
                getal = Convert.ToInt32(AantalCookies.Content) - 10000;
                AantalCookies.Content = getal;
                CookieversiumLevelLabel2.Content = Convert.ToInt32(CookieversiumLevelLabel2.Content) + 1;
            }
        }

        private void SpaceCookieTransformer_Click(object sender, RoutedEventArgs e)
        {
            Cookie.Fill = new SolidColorBrush(Colors.Purple);
            Chocolate1.Fill = new SolidColorBrush(Colors.Green);
            Chocolate2.Fill = new SolidColorBrush(Colors.Green);
            Chocolate3.Fill = new SolidColorBrush(Colors.Green);
            Cookie.Stroke = new SolidColorBrush(Colors.Green);
            Chocolate1.Stroke = new SolidColorBrush(Colors.Purple);
            Chocolate2.Stroke = new SolidColorBrush(Colors.Purple);
            Chocolate3.Stroke = new SolidColorBrush(Colors.Purple);
        }

        private void NormalCookieTransformer_Click(object sender, RoutedEventArgs e)
        {
            Cookie.Fill = new SolidColorBrush(Colors.SandyBrown);
            Chocolate1.Fill = new SolidColorBrush(Colors.SaddleBrown);
            Chocolate2.Fill = new SolidColorBrush(Colors.SaddleBrown);
            Chocolate3.Fill = new SolidColorBrush(Colors.SaddleBrown);
            Cookie.Stroke = new SolidColorBrush(Colors.SaddleBrown);
            Chocolate1.Stroke = new SolidColorBrush(Colors.SandyBrown);
            Chocolate2.Stroke = new SolidColorBrush(Colors.SandyBrown);
            Chocolate3.Stroke = new SolidColorBrush(Colors.SandyBrown);
        }
    }
}
