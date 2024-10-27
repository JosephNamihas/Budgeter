﻿using System;
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

        public List<int> IncomingFunds = new List<int>() { }; // For calculating grand totals
        public List<int> OutgoingFunds = new List<int>() { };

        public MainWindow()
        {
            InitializeComponent();

        }

        private void IncomeButton_Click(object sender, RoutedEventArgs e)
        {
            string incomeItem = IncomeName.Text; // The UI Element
            int incomeVal = 0; // The value, the user inputs in IncomeAmount.Text
            int incomeTotal = 0; // The sum of the income

            try
            {
                incomeVal = int.Parse(IncomeAmount.Text);
            } catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            
            AddToList_Income(incomeItem, incomeVal);

            foreach (int item in IncomingFunds)
            {
                incomeTotal += item;
            }

            TotalIncome.Text = incomeTotal.ToString();

        }

        private void ExpenditureButton_Click(object sender, RoutedEventArgs e)
        {
            
            string expenditureItem = ExpenditureName.Text; // The UI element
            int expenVal = 0; // The value, the user inputs in ExpenditureAmount.Text
            int expenTotal = 0; // The sum of the expenditures


            try
            {
                expenVal = int.Parse(ExpenditureAmount.Text);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            AddToList_Expenditure(expenditureItem, expenVal);

            foreach (int item in OutgoingFunds)
            {
                expenTotal += item;
            }

            TotalExpenditure.Text = expenTotal.ToString();

        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {

        }

        void AddToList_Income(string itemName, int itemValue)
        {
            ListBoxIncome.Items.Add(new Expenditure(itemName, ((int)itemValue)));
            IncomingFunds.Add(itemValue);
            // Run function to recalculate all Expenditures in Class
        }

        void AddToList_Expenditure(string itemName, int itemValue)
        {
            ListBoxExpenditure.Items.Add(new Expenditure(itemName, ((int)itemValue)));
            OutgoingFunds.Add(itemValue);
        }




    }
}