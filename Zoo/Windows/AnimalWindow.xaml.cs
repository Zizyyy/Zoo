using System;
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
using Zoo.ClassHelper;
using Zoo.DB;

namespace Zoo.Windows
{
    /// <summary>
    /// Логика взаимодействия для AnimalWindow.xaml
    /// </summary>
    public partial class AnimalWindow : Window
    {
        List<string> sortList = new List<string>()
        {
            "Выбрать класс",
            "Млекопитающие",
            "Птицы",
            "Рептилии",
            "Амфибии",
            "Рыбы",
            "Безпозвоночные"
        };

        public AnimalWindow()
        {
            InitializeComponent();
            GetInfo();

            CmbSort.ItemsSource = sortList;
            CmbSort.SelectedIndex = 0;
        }

        public void  GetInfo()
        {
            List<Animal> listAnimal = new List<Animal>();

            listAnimal = EFTClass.context.Animal.ToList();

            switch (CmbSort.SelectedIndex)
            {
                case 1:
                    listAnimal = listAnimal.Where(x => x.SpeciasID == CmbSort.SelectedIndex).ToList();
                    break;
                case 2:
                    listAnimal = listAnimal.Where(x => x.SpeciasID == CmbSort.SelectedIndex).ToList();
                    break;
                case 3:
                    listAnimal = listAnimal.Where(x => x.SpeciasID == CmbSort.SelectedIndex).ToList();
                    break;
                case 4:
                    listAnimal = listAnimal.Where(x => x.SpeciasID == CmbSort.SelectedIndex).ToList();
                    break;
                case 5:
                    listAnimal = listAnimal.Where(x => x.SpeciasID == CmbSort.SelectedIndex).ToList();
                    break;
                case 6:
                    listAnimal = listAnimal.Where(x => x.SpeciasID == CmbSort.SelectedIndex).ToList();
                    break;
            }

            LvAnimal.ItemsSource = listAnimal;
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

        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if(button == null)
            {
                return;
            }
            var animal = button.DataContext as Animal;
            
            CertainAnimalWindow certainAnimalWindow = new CertainAnimalWindow(animal);
            certainAnimalWindow.Show();
        }

        private void CmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GetInfo();
        }
    }
}
