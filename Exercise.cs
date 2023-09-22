using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Exercise
    {
        private string _exerciseName;
        public string ExerciseName 
        { 
            get
            {
              return _exerciseName;  
            }
            set
            {
                _exerciseName = value;
            } 
        }
        
        private int _series;
        public int Series  
        { 
            get
            {
              return _series;
            }
            set
            {
              _series = value;   
            } 
        }

        private int _repetitions;
        public int Repetitions 
        { 
            get
            {
              return _repetitions;        
            }
            set
            {
               _repetitions = value;
            } 
        }

        private string _movement;
        public string Movement  
        { 
            get
            {
               return _movement; 
            }
            set
            {
                _movement = value;
            } 
        }

        private double _rm;
        public double RM 
        { 
            get
            {
              return _rm;  
            }
            set
            {
               _rm = value;
            } 
        }

        private string _implements;
        public string Implements  
        { 
            get
            {
              return _implements;  
            }
            set
            {
               _implements = value;
            } 
        }
    }
}
