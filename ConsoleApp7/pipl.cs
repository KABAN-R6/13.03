using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class pipl : Iobserver
    {
        public string Name = " Коля";
        public string status = "VIP";
        Iobservable proga;
        public pipl(string name, Iobservable obs)
        {
            this.Name = name;
            proga = obs;
            proga.Addobserver(this);
        }
        public void Update(object ob)
        {
            datainfo storeInfo = (datainfo)ob;
            if (storeInfo.discount < 10)
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
