using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budgeter
{
    public class Expenditure
    {
        public string Name { get; set; }
        public int ExpenditureAmount { get; set; }

        /*int IncomeTotal()
        {
            // Return total of all objects IncomeAmount
        }*/

        public Expenditure(string _name, int _amount)
        {
            Name = _name;
            ExpenditureAmount = _amount;
        }

        // Function for Total Amount


    }
}