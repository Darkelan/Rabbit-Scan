using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Windows.Controls.Ribbon;

namespace Rabbit_Scan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            //ComboBox mit den im Netzwerk gefundenen Rechnern füllen
            
            //Einen Eintrag für den localhost machen
            comboBox1.Items.Add("<Eigener PC>");
            //Diesen vorab selektieren
            comboBox1.SelectedIndex = 0;
            // Zum scannen des Eigenen PC´s sind Admin-Rechte nötig, Zugangsdaten müssen nicht eingegeben werden, daher die beiden folgenden Felder inaktiv setzen
            textBox2.IsEnabled = false;
            passwordBox1.IsEnabled = false;
            try
            {
                NetworkBrowser nb = new NetworkBrowser();
                foreach (string pc in nb.getNetworkComputers())
                {
                    comboBox1.Items.Add(pc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred trying to access the network computers: " + ex, "error", MessageBoxButton.OK);
            }
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hier kommt noch Text");
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hier kommt noch Text");
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hier kommt noch Text");
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hier kommt noch Text");
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hier kommt noch Text");
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hier kommt noch Text");
        }

        //ComboBox Auswahl ändern. Wenn etwas anderes als Eigener PC ausgewählt wird (Index=0) können Zugangsdaten eingegeben werden
        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                textBox2.IsEnabled = true;
                passwordBox1.IsEnabled = true;
            }

            else
            {
                textBox2.IsEnabled = false;
                passwordBox1.IsEnabled = false;
            }
        }
                       
        }
        
}

