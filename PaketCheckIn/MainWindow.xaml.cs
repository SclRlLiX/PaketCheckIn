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

namespace PaketCheckIn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // ###################################################
            // ############### FORM DEFAULT VALUES ############### 
            // ###################################################


            //Combo Box cbChooseOption
            cbChooseOption.Items.Add("Neue Paketversion");
            cbChooseOption.Items.Add("Bestehende Paketversion anpassen");
            cbChooseOption.Items.Add("Neues Paket");

            // Combo Box 
            cbChooseFolder.IsEnabled = false;
        }
    }
}
