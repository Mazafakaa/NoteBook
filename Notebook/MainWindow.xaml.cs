using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using NoteBookDL;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Notebook
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static People people = new People();
        IMainController controller;
        public MainWindow()
        {
            InitializeComponent();
            controller = new MainController();
            notebox.ItemsSource = controller.GetPeopleList();
            
        }
        //Кнопка Удалить
        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            if(notebox.SelectedItem != null)
            {
                People i = (People)notebox.SelectedItem;
                List<People> peoples = controller.DelPeople(i.Id);
                notebox.ItemsSource = null;
                notebox.ItemsSource = peoples;
                FIO.Text = "";
                Telephone.Text = "";
                Email.Text = "";

            }
        }
        //Кнопка Добавить
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            people.Id = 0;
            DataOfBirthday.Text = DateTime.Now.Date.ToString();
            FIO.Text = people.FIO = Telephone.Text = people.Telephone = people.Email = Email.Text = ""; 

        }
        //Кнопка Изменить
        private void btnRed_Click(object sender, RoutedEventArgs e)
        {
           if(notebox.SelectedItem != null)
            {
                people = (People)notebox.SelectedItem;
                FIO.Text = people.FIO;
                Telephone.Text = people.Telephone;
                Email.Text = people.Email;
            }
        }
        //Кнопка Сохранить
        private void submit_Click(object sender, RoutedEventArgs e)
        {
            people.FIO = FIO.Text;
            people.Email = Email.Text;
            people.Telephone = Telephone.Text;
            DateTime dat;
            //Если удастся пропарсить - то пишем в бд
            if(DateTime.TryParse(DataOfBirthday.Text,out dat))
            {
                people.DateOfBirthday = dat;
                List<People> peoples = controller.EditOrCreate(people);
                notebox.ItemsSource = null;
                notebox.ItemsSource = peoples;
                FIO.Text = people.FIO = Telephone.Text = people.Telephone = people.Email = Email.Text = "";
            }
            //На нет и суда нет, выводим сообщение юзеру о том что он не ввел дату
            else
            {
                MessageBox.Show("Введите дату                          ");
            }
            
        }
    }
    
    
}
