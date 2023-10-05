using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Rutine
    {
        private string _type;
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        
        private string _intensity;
        public string Intensity
        {
            get
            {
               return _intensity;
            } 
            set
            {
               _intensity = value;
            } 
        }
        
        private int _time;
        public int Time 
        {
            get
            {
               return _time;   
            } 
            set
            {
               _time = value;
            } 
        }

        private int _rest;
        public int Rest 
        { 
            get
            {
               return _rest;   
            } 
            set
            {
               _rest = value; 
            } 
        }

        private string _days;
        public string Days 
        {
            get
            {
              return _days;    
            } 
            set
            {
              _days = value; 
            }
        }
        private Exercise[] _exercises;
        public Exercise[] Exercise
        {
            get
            {
                return _exercises;
            }
            set
            {
                _exercises = value;
            }
        }

        public Rutine(string type,string intensity,int time, int rest, string days, Exercise[] exercises)
        { 
            _type = type;
            _intensity = intensity;
            _time = time;
            _rest = rest;
            _days = days;
            _exercises = exercises;
        }

    }
}
