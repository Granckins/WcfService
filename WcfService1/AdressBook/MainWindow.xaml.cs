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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Services.Client;
using AdressBook.ServiceReference1;
namespace AdressBook
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    ///  
    public partial class MainWindow : Window
    {
        private AdressDBEntities context; 

        
        private Uri svcUri = new Uri("http://localhost:14730/WcfDataService1.svc/");

        public MainWindow()
        {
            InitializeComponent();      
             try
             { 
                 context = new AdressDBEntities(svcUri); 
                 this.orderItemsGrid.DataContext = GetContactList();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }
        }
        private DataServiceCollection<AdressBook.ServiceReference1.Table> GetContactList()
        {
            var ordersQuery = from c in context.Table
                              select c;
            return new DataServiceCollection<AdressBook.ServiceReference1.Table>(ordersQuery);
        }
        bool isInsertMode = false;
        bool isBeingEdited = false;
        private void buttonSaveChanges_Click(object sender, RoutedEventArgs e)
        {
          
             var Res = MessageBox.Show("Вы уверены, что хотите сохранть внесенные изменения в записи ?", "Сохранение изменений", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
             if (Res == MessageBoxResult.Yes)
             {
                 try
                 {
                     context.SaveChanges();
                 }
                 catch (DataServiceRequestException ex)
                 {
                     MessageBox.Show(ex.ToString());

                 }
             }
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void dgEmp_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            AdressBook.ServiceReference1.Table contact = new AdressBook.ServiceReference1.Table();
            AdressBook.ServiceReference1.Table cont = e.Row.DataContext as AdressBook.ServiceReference1.Table;

            cont.Id = GetContactList().Last().Id + 1;
            if (isInsertMode)
            {
                var InsertRecord = MessageBox.Show("Вы хотите добавить " + cont.FIO+ " в контакты?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (InsertRecord == MessageBoxResult.Yes)
                {

                    try
                    {
                        contact.FIO = cont.FIO;
                        contact.Phone = cont.Phone;
                        context.AddObject("Table", contact);
                        context.SaveChanges();
                        orderItemsGrid.DataContext = GetContactList();
                    }
                    catch (DataServiceRequestException ex)
                    {
                    }MessageBox.Show(contact.FIO + " " + " добавлен!", "Добавление записи", MessageBoxButton.OK, MessageBoxImage.Information);
                
                }
                else
                    orderItemsGrid.DataContext = GetContactList();
               
            }
         
          
        }
        private void dgEmp_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete && !isBeingEdited)
            {
                var grid = (DataGrid)sender;
                if (grid.SelectedItems.Count > 0)
                {
                    var Res = MessageBox.Show("Вы уверены, что хотите удалить " + grid.SelectedItems.Count + " из контактов?", "Удаление записи", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
                    if (Res == MessageBoxResult.Yes)
                    {
                        foreach (var row in grid.SelectedItems)
                        {
                            AdressBook.ServiceReference1.Table contact = row as AdressBook.ServiceReference1.Table;
                            context.DeleteObject(contact);
                        }
                        context.SaveChanges();
                        MessageBox.Show(grid.SelectedItems.Count + " Контакт удален!");
                    }
                    else
                        orderItemsGrid.DataContext = GetContactList();
                }
            }
        }
        private void dgEmp_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {
            isInsertMode = true;
        }

        private void dgEmp_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
           
            isBeingEdited = true;
        }

        private void orderItemsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
            }
   
 
}
