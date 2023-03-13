using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Celebration
    {
        private DateTime _time;
        private string _name;
        private Root _root;

        public Celebration(DateTime time, string name,Root root)
        {
            
            _name = name;
            
            _root = root;
            _time = time;
        }
        public string Name
        {
            get { return _name; }
        }
        public Root Root
        {
            get { return _root; }
        }
        public bool Check(DateTime time)
        {
            if (time.AddDays(7) == time) return true;
            return false;
        }
    }
}
