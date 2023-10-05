using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        private Usuario[] _usuario;
        public Usuario[] Usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                _usuario = value;
            }
        }

        public Diet(double caloriesNumber, string suggestedFood, string restriction, string supplements, Usuario[] usuario)
        {
            _caloriesNumber = caloriesNumber;
            _suggestedFood = suggestedFood;
            _restriction = restriction;
            _supplements = supplements;
            _usuario = usuario;     

        }

    }
}
