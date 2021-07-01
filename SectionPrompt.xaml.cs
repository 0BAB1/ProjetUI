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

        //buttons dimensions in general
        private int buttonMargin = 10;
        private int buttonHeight = 50;
        private Thickness LeftMargin = new Thickness(10,0,0,0); //has to be equal to buttonMargin !


        //to return a button width
        public int widthB
        {
            get { return ((int)this.Width-(3*this.buttonMargin))/4; }
        }

        //to return a buttton height
        public int heightB
        {
            get { return this.buttonHeight; }
        }

        //return the margin
        public Thickness marginB
        {
            get { return this.LeftMargin; }
        }

        private void buttonPrompt_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        //different menus on buttons click
        private void buttonSquare_Click(object sender, RoutedEventArgs e)
        {
            this.emptySquare.Visibility = Visibility.Collapsed;
            this.square.Visibility = Visibility.Visible;
            this.circle.Visibility = Visibility.Collapsed;
            this.emptyCircle.Visibility = Visibility.Collapsed;
        }

        private void buttonEmptySquare_Click(object sender, RoutedEventArgs e)
        {
            this.emptySquare.Visibility = Visibility.Visible;
            this.square.Visibility = Visibility.Collapsed;
            this.circle.Visibility = Visibility.Collapsed;
            this.emptyCircle.Visibility = Visibility.Collapsed;
        }

        private void buttonCircle_Click(object sender, RoutedEventArgs e)
        {
            this.emptySquare.Visibility = Visibility.Collapsed;
            this.square.Visibility = Visibility.Collapsed;
            this.circle.Visibility = Visibility.Visible;
            this.emptyCircle.Visibility = Visibility.Collapsed;
        }

        private void buttonEmptyCircle_Click(object sender, RoutedEventArgs e)
        {
            this.emptySquare.Visibility = Visibility.Collapsed;
            this.square.Visibility = Visibility.Collapsed;
            this.circle.Visibility = Visibility.Collapsed;
            this.emptyCircle.Visibility = Visibility.Visible;
        }
    }
}
