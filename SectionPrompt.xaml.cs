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
            this.DataContext = this;
        }

        private int buttonMargin = 10;
        private int buttonHeight = 40;

        public int widthB
        {
            get { return ((int)this.Width-(5*this.buttonMargin))/4; }
            set { this.buttonMargin = value; }
        }

        public int heightB
        {
            get { return this.buttonHeight; }
            set { this.buttonHeight = value; }
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
