using System;
using System.Numerics;
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

        public List<int> IncomingFunds = new List<int>()
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
            int expenVal = 0;
            string expenditureName = ExpenditureName.Text;
            int expenAmount = 0;

            try
            {
                expenVal = int.Parse(ExpenditureAmount.Text);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            ListBoxExpenditure.Items.Add(new Expenditure(expenditureName, ((int)expenVal)));
            // Run function to recalculate all IncomeAmounts in Income Class

            IncomingFunds.Add(expenVal);

            int total = 0;

            foreach (int item in IncomingFunds)
            {
                total += item;
            }

            TotalExpenditure.Text = total.ToString();

        }

    }
}