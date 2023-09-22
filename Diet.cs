using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Diet
    {
        private double _caloriesNumber; 
        public double CaloriesNumber 
        { 
            get
            {
              return _caloriesNumber;  
            } 
            set
            {
               _caloriesNumber= value; 
            }
        }

        private string _suggestedFood;
        public string SuggestedFood 
        { 
            get
            {
                return _suggestedFood;
            }
            set
            {
                _suggestedFood = value;
            } 
        }

        private string _restriction;
        public string Restriction 
        { 
            get
            {
                return _restriction;
            } 
            set
            {
                 _restriction = value;    
            } 
        }

        private string _supplements;
        public string Supplements
        { 
            get
            {
               return _supplements;    
            } 
            set
            {
                _supplements = value;
            }
        }
    }
}
