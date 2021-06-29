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
    /// Logique d'interaction pour SectionPrompt.xaml
    /// </summary>
    public partial class SectionPrompt : Window
    {
        public SectionPrompt()
        {
            InitializeComponent();
        }

        public string result
        {
            get { return toSubmit.Text; }
            set { toSubmit.Text = value; }
        }

        private void buttonPrompt_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
