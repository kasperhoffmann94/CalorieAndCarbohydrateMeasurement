using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Domain
{
    public class Calculation
    {
        private double CalcCaloriePerGram(double calories)
        {
            double result = 0.0;
            result = calories / 100.0;

            return result;
        }


        public double caloriesInGivenGram(double caloriesPerHundred, double gram)
        {
            double result = 0.0;
            result = CalcCaloriePerGram(caloriesPerHundred) * gram;

            return result;
        }
    }
}
