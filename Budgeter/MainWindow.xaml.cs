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

        public List<int> OutgoingFunds = new List<int>()
        {


        };

        public MainWindow()
        {
            InitializeComponent();


        }

        private void IncomeButton_Click(object sender, RoutedEventArgs e)
        {
            string incomeItem = IncomeName.Text;
            int incomeVal = 0;

            try
            {
                incomeVal = int.Parse(IncomeAmount.Text);
            } catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            
            ListBoxIncome.Items.Add(new Income(incomeItem, ((int)incomeVal)));
            // Run function to recalculate all IncomeAmounts in Income Class

            IncomingFunds.Add(incomeVal);

            int incomeTotal = 0;

            foreach (int item in IncomingFunds)
            {
                incomeTotal += item;
            }

            TotalIncome.Text = incomeTotal.ToString();

        }

        private void ExpenditureButton_Click(object sender, RoutedEventArgs e)
        {
            int expenVal = 0;
            string expenditureName = ExpenditureName.Text;


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

            OutgoingFunds.Add(expenVal);

            int expenTotal = 0;

            foreach (int item in OutgoingFunds)
            {
                expenTotal += item;
            }

            TotalExpenditure.Text = expenTotal.ToString();

        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            IncomingFunds.Clear();
            OutgoingFunds.Clear();
        }

    }
}