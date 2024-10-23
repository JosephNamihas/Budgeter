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
            double userVal = 0;

           try
            {
                userVal = double.Parse(IncomeAmount.Text);
            } catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            
            ListBoxIncome.Items.Add(new Income(IncomeName.Text, ((int)userVal)));
            // Run function to recalculate all IncomeAmounts in Income Class
            
        }

        private void ExpenditureButton_Click(object sender, RoutedEventArgs e)
        {
            double expenVal = 0;

            try
            {
                expenVal = double.Parse(ExpenditureAmount.Text);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            ListBoxExpenditure.Items.Add(new Expenditure(ExpenditureName.Text, ((int)expenVal)));
            // Run function to recalculate all IncomeAmounts in Income Class

        }
    }
}