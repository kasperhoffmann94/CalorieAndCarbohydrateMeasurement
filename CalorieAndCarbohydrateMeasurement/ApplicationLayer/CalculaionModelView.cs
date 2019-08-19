using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;


namespace ApplicationLayer
{
   public class CalculaionModelView
    {
        public CalculaionModelView()
        {
            Calculation calc = new Calculation();
        }

        private double Calculate(Calculation calc, double caloriesPerHundred, double gram)
        {
            return calc.caloriesInGivenGram(caloriesPerHundred, gram);
        }
    }
}
