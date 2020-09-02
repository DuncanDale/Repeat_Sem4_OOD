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

namespace DaleDuncan_S00123318
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

        private void Lbx_computers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //gets the selected computer
            Computer selectComputer = lbx_computers.SelectedItem as Computer;

            //check to make sure the selection is not null
            if (selectComputer != null)
            {
                ImgComputer.Source = new BitmapImage(new Uri(selectComputer.Computer_Image, UriKind.Relative));
            }


        }





    }
}
