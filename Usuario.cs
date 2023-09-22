using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Usuario
    {
        private string _name;
        public string Name 
        { 
            get
            {
               return _name;        
            } 
            set
            {
                _name = value;
            } 
        }
        
        private int age;
        public int Age 
        {
            get
            {
              return _age;  
            }
            set
            {
               _age = value;   
            } 
        }

        private double _weight; 
        public double Weight 
        { 
            get
            {
              return _weight;    
            } 
            set
            {
               _weight = value;
            } 
        }

        private double _height;
        public double Height 
        { 
            get
            {
             return _height;        
            } 
            set
            {
              _height = value;  
            } 
        }

        private string _physicalLevel;
        public string PhysicalLevel 
        { 
            get
            {
               return _physicalLevel;        
            } 
            set
            {
               _physicalLevel = value;  
            } 
        }

        private string _objetive;
        public string Objective 
        { 
            get
            {
               return _objetive;        
            } 
            set
            {
                _objetive = value;
            } 
        }

        private string _genre;
        public string Genre 
        { 
            get
            {
              return _genre;  
            } 
            set
            {
                _genre = value;
            } 
        }

        private string _unitType;
        public string UnitType 
        { 
            get
            {
              return _unitType;  
            } 
            set
            {
                _unitType = value;
            } 
        }
    }
}

