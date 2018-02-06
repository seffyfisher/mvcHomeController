using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcHomeController.Models
{
    public class NumberIncome
    {
        public double myDouble { get; set; }

        public bool IsInt()
        {
            if (myDouble % 1 > 0) { return false; }
            else { return true; }
                
        }

        public bool IsEvenNumber()
        {
            if(this.myDouble%2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}