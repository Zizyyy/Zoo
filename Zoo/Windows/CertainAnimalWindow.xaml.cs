using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using Zoo.ClassHelper;
using Zoo.DB;

namespace Zoo.Windows
{
    /// <summary>
    /// Логика взаимодействия для CertainAnimalWindow.xaml
    /// </summary>
    public partial class CertainAnimalWindow : Window
    {
       // private Animal animal;
        public CertainAnimalWindow()
        {

            InitializeComponent();
        }

        public CertainAnimalWindow(Animal animal)
        {

            InitializeComponent();
            TblInformation.Text = animal.Information.ToString();
            TblName.Text = animal.Name;
        }

        private void ToolBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
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

        private void BtnHome_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
