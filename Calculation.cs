using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project1
{
    public class Calculation
    {
     public static double total(int size, int filling, int extra, int meal, double tip)
        {
            double total = size + (filling * 0.25) + (extra * 1) + (meal * 2) + tip;
            return total;
            
        }

       public static double totalFilling(int filling)
        {
            double total = filling * 0.25;
            return total;
        }

        public static int totalExtra(int extra)
        {
            int total = extra * 1;
            return total;
        }

        public static int totalMeal(int meal)
        {
            int total = meal * 2;
            return total;
        }
    
    
    
    }
}