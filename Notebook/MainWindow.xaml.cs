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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            people.Id = 0;
            FIO.Text = people.FIO = Telephone.Text = people.Telephone = people.Email = Email.Text = ""; 

        }

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

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            people.FIO = FIO.Text;
            people.Email = Email.Text;
            people.Telephone = Telephone.Text;
            people.DateOfBirthday = DateTime.Parse(DataOfBirthday.Text).Date;
            List<People> peoples = controller.EditOrCreate(people);
            notebox.ItemsSource = null;
            notebox.ItemsSource = peoples;
            FIO.Text = people.FIO = Telephone.Text = people.Telephone = people.Email = Email.Text = "";
        }
    }
    
    
}
