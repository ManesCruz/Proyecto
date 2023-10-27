﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Rutine
    {
        private string _type;
        private string _intensity;
        private int _time;
        private int _rest;
        private string _days;
        private Exercise _exercises;

        public string Type { get => _type; set => _type = value; }
        public string Intensity { get => _intensity; set => _intensity = value; } 
        public int Time { get => _time; set => _time = value; } 
        public int Rest { get => _rest; set => _rest = value; } 
        public string Days { get => _days; set => _days = value; }
        public Exercise Exercise { get => _exercises; set => _exercises = value; }
    

        public Rutine(string type,string intensity,int time, int rest, string days, Exercise exercises)
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
