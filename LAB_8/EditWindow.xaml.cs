//ЗАОКОННЫЙ КОД ОКНА РЕДАКТИРОВАНИЯ
using LAB_8.Models;
using System.Windows;


namespace LAB_8
{
    /// <summary>
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        Payment payment;
        public EditWindow()
        {
            InitializeComponent();           
        }

        public EditWindow(Payment payment):this()
        {
            this.payment = payment; 
            grid.DataContext = payment;
        }
        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;            
        }
    }
}
