using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class pipl3 : Iobserver
    {
        public string Name = "Настя";
        public string status = "Amateur";
        Iobservable proga;
        public pipl3(string name, Iobservable obs)
        {
            this.Name = name;
            proga = obs;
            proga.Addobserver(this);
        }
        public void Update(object ob)
        {
            datainfo Info = (datainfo)ob;
            if ()
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
