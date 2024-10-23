using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budgeter
{
    public class Income
    {
        public string Name { get; set; }
        public int IncomeAmount { get; set; }

        public Income(string _name, int _amount)
        {
            Name = _name;
            IncomeAmount = _amount;
        }

        // Function for Total Amount


    }
}
