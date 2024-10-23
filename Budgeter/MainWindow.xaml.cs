using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Budgeter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<Income> IncomingFunds = new List<Income>()
        {
            

        };
        

      

        public MainWindow()
        {
            InitializeComponent();

            //ListBoxIncome.ItemsSource = IncomingFunds;
        }

        private void IncomeButton_Click(object sender, RoutedEventArgs e)
        {
            int userVal = int.Parse(IncomeAmount.Text);
            ListBoxIncome.Items.Add(new Income(IncomeName.Text, userVal));
          
        }

        
    }
}