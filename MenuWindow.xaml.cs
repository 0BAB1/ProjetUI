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
    /// Logique d'interaction pour MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void buttonCalcul_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int valueOne = int.Parse(numberOne.Text);
                int valueTwo = int.Parse(numberTwo.Text);
                result.Text = "bg";
            }
            catch(Exception ex)
            {
                result.Text = "mauvaise input";
            }
        }
    }
}
