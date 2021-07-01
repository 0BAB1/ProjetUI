using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjetUI
{
    /// <summary>
    /// Logique d'interaction pour Traction.xaml
    /// </summary>
    public partial class Traction : Window
    {
        public Traction()
        {
            InitializeComponent();
        }

        private void buttonSection_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SectionPrompt();
            if(dialog.ShowDialog() == true)
            {
                result.Text = "bg";
            }
        }
    }
}
