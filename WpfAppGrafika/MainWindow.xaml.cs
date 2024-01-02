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

namespace WpfAppGrafika
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<BitmapImage> Images { get; set; }
        public int aktualnyIndeks { get; set; }
        public int Maks { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            przygotujObrazki();
            Maks = Images.Count - 1;
            aktualnyIndeks = 0;
            DataContext = this;
        }

        private void przygotujObrazki()
        {
            Images = new List<BitmapImage>();
            Images.Add(new BitmapImage(new Uri("grafika/rys1.jpg", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys2.jpg", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys3.jpg", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys4.jpg", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys5.jpg", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys6.jpg", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys7.jpg", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys8.jpg", UriKind.Relative)));
        }
        private void Dalej_Click(object sender, RoutedEventArgs e)
        {
            aktualnyIndeks++;
            if (aktualnyIndeks == Images.Count)
                aktualnyIndeks = 0;
            obraz.Source = Images[aktualnyIndeks];
        }

        private void Nazot_Click(object sender, RoutedEventArgs e)
        {
            aktualnyIndeks--;
            if (aktualnyIndeks == -1)
                aktualnyIndeks = Images.Count-1;
            obraz.Source = Images[aktualnyIndeks];
        }

        private void Zmiana1_Radio(object sender, RoutedEventArgs e)
        {
            obraz_radio.Source = new BitmapImage(new Uri("grafika/rys1.jpg",UriKind.Relative));
        }

        private void Zmiana_Click(object sender, RoutedEventArgs e)
        {
            int indeks = (int) slider.Value;
            obraz_suwak.Source = Images[indeks];
        }

        private void obrazki_comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int indeks = obrazki_comboBox.SelectedIndex;
            obraz_combo.Source = Images[indeks];
        }
    }
}
