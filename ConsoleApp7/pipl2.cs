using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class pipl2 : Iobserver
    {
        public string Name = "Дима";
        public string status = "Rookie";
        Iobservable proga;
        public pipl2(string name, Iobservable obs)
        {
            this.Name = name;
            proga = obs;
            proga.Addobserver(this);
        }
        public void Update(object ob)
        {
            datainfo info = (datainfo)ob;
            if (info. < 10)
                Console.WriteLine();
            else
                Console.WriteLine();
        }
        public void StopStore()
        {
            proga.RemoveObserver(this);
            proga = null;
        }
    }
}
