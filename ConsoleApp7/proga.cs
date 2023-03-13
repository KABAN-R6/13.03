using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class proga : Iobservable
    {
        datainfo sinfo;

        List<Iobserver> observers;
        public proga()
        {
            observers = new List<Iobserver>();
            sinfo = new datainfo();
        }
        public void Addobserver(Iobserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(Iobserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObserver()
        {
            foreach (Iobserver o in observers)
            {
                o.Update(sinfo);
            }
        }
                
    }
}
