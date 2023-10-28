using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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
using Zoo.Properties;

namespace Zoo.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ToolBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void BtnMinimize_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BtnClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void BtnRules_Click(object sender, RoutedEventArgs e)
        {
            Rules rules = new Rules();
            rules.Show();
            this.Close();
        }

        private void BtnTiket_Click(object sender, RoutedEventArgs e)
        {
            TicketWindow ticket = new TicketWindow();
            ticket.Show();
            this.Close();
        }

        private void BtnAnimal_Click(object sender, RoutedEventArgs e)
        {
            AnimalWindow animal = new AnimalWindow();
            animal.Show();
            this.Close();
        }

        private void BtnBuy_Click(object sender, RoutedEventArgs e)
        {
            BuyTicketWindow buyTicket = new BuyTicketWindow();
            buyTicket.Show();
        }
    }
}
