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
    /// Логика взаимодействия для BuyTicketWindow.xaml
    /// </summary>
    public partial class BuyTicketWindow : Window
    {
        List<string> listCategory = new List<string>()
        {
            "Тип биллета",
            "Взрослые граждане",
            "Дети в возрасте от 7 до 17 лет включительно",
            "Дети до 7 лет (не достигшие семилетнего возраста)",
            "Лица из многодетных семей",
            "Инвалиды I и II группы",
            "Пенсионеры",
            "Студенты очной формы обучения",
            "Участники ВОВ. участники боевых действий"
        };

        public BuyTicketWindow()
        {
            InitializeComponent();


            CmbTypeTicket.SelectedIndex = 0;
            CmbTypeTicket.ItemsSource = listCategory;

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

        private void CmbTypeTicket_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (CmbTypeTicket.SelectedIndex)
            {
                case 1:
                    TblPrice.Text = "1000,00 ₽";
                    break;
                default:
                    TblPrice.Text = "0,00 ₽";
                    break;
            }
        }

        private void BtnBuyTicket_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbFName.Text))
            {
                MessageBox.Show("Поле \"Фамилия\" не может быть пустым.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(TbLName.Text))
            {
                MessageBox.Show("Поле \"Фамилия\" не может быть пустым.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(TbPhone.Text))
            {
                MessageBox.Show("Поле \"Телефон\" не может быть пустым.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(TbEmail.Text))
            {
                MessageBox.Show("Поле \"Электронная почта\" не может быть пустым.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Client client = new Client();
            client.LName = TbLName.Text;
            client.FName = TbFName.Text;
            client.MName = TbMName.Text;
            client.Email = TbEmail.Text;
            client.Phone = TbPhone.Text;

            EFTClass.context.Client.Add(client);
            EFTClass.context.SaveChanges();

            //Order order = new Order();
            //order.DateSale = DateTime.Now;
            //order.ClientID = Convert.ToInt32(EFTClass.context.Client.Where(x => x.Email.ToString() == TbEmail.Text && 
            //                                                               x.Phone.ToString() == TbPhone.Text));
            //order.TypeTicketID = CmbTypeTicket.SelectedIndex;
            //EFTClass.context.Order.Add(order);
            //EFTClass.context.SaveChanges();
            MessageBox.Show("Билет куплен.");
        }
    }
}
