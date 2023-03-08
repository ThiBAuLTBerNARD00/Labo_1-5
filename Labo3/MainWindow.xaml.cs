using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using MaLibrairieForme;

namespace Labo3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ObservableCollection<Forme> ListeForme = new();
        public MainWindow()
        {
            InitializeComponent();
            ListViewForm.ItemsSource = ListeForme;
        }

        private void ComboBoxForm_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!IsInitialized) return;

            ComboBoxItem item = (ComboBoxItem)ComboBoxForm.SelectedItem;
            if (item is not null)
            {
                if (item.Content.Equals("Rectangle"))
                {
                    LabelLongueur.Content = "Longueur";
                    LabelLargeur.Visibility = Visibility.Visible;
                    TextBoxLargeur.Visibility = Visibility.Visible;
                }
                else
                {
                    if (item.Content.Equals("Carre"))
                    {
                        LabelLongueur.Content = "Côté";
                    }
                    else
                    {
                        LabelLongueur.Content = "Rayon";
                    }
                    LabelLargeur.Visibility = Visibility.Hidden;
                    TextBoxLargeur.Visibility = Visibility.Hidden;
                }
            }

        }
        private void ListViewForm_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListViewForm.SelectedItem is null)
            {
                LabelFormInfos.Content = "AUCUNE FORME SELECTIONNEE !";
            }
            else
            {
                LabelFormInfos.Content = ListViewForm.SelectedItem.GetType().Name + " : " + ListViewForm.SelectedItem.ToString();
            }
        }

    }
}
