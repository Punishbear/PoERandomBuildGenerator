﻿using System;
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

namespace PoERandomBuildGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //PoERandomBuildGeneratorViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();

            genBuildButton.Click += GenBuildButton_Click;

            //viewModel = new PoERandomBuildGeneratorViewModel();
            //DataContext = viewModel;
        }

        private void GenBuildButton_Click(object sender, RoutedEventArgs e)
        {
            ((PoERandomBuildGeneratorViewModel)DataContext).KeystoneAmount = (int)keystoneAmount.Value;
            ((PoERandomBuildGeneratorViewModel)DataContext).GenerateBuild();
        }
    }
}