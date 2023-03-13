using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class pipl2 : Iobserver
    {
        public string Name = "";
        Iobservable store;
        public pipl2(string name, Iobservable obs)
        {
            this.Name = name;
            store = obs;
            store.Addobserver(this);
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
            store.RemoveObserver(this);
            store = null;
        }
    }
}
