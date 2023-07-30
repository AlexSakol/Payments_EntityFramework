//ЗАОКОННЫЙ КОД ГЛАВНОГО ОКНА
using LAB_8.Models;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;


namespace LAB_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EntityContext context;
        public MainWindow()
        {
            InitializeComponent();
            context = new EntityContext();
            context.payments.Load();
            dGrid.ItemsSource = context.payments.Local.ToBindingList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Payment payment = new Payment();
            EditWindow editWindow = new EditWindow(payment);
            if(editWindow.ShowDialog() == true)
            {
                context.payments.Add(payment);
                context.SaveChanges();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы уверены?", "Удалить запись", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                if (dGrid.SelectedItems.Count > 0)
                {
                    for (int i = dGrid.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        Payment payment = dGrid.SelectedItems[i] as Payment;
                        if (payment != null)
                        {
                            context.payments.Remove(payment);
                        }
                    }
                    context.SaveChanges();
                }
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Payment payment = dGrid.SelectedItem as Payment;        
            EditWindow editWindow = new EditWindow(payment);
            if (editWindow.ShowDialog() == true)
            {                   
                context.SaveChanges();                
            }
            else
            {                
                context.Entry(payment).Reload();
                dGrid.DataContext = null;
                dGrid.DataContext = context.payments.Local;                
            }
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            context.Dispose();
        }

        private void dGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }
    }
}
