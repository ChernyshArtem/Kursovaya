﻿using System;
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
using System.Windows.Shapes;

namespace RegastrationOfTheWeddingOrganizer.Settings
{
    /// <summary>
    /// Логика взаимодействия для SettingsMenu.xaml
    /// </summary>
    public partial class SettingsMenu : Window
    {
        public SettingsMenu()
        {
            InitializeComponent();
        }
        private void OpenMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
