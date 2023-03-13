using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class proga : Iobservable
    {
        List<user> users;
        List<cellebration> cellebrations;
        
        public proga()
        {
            users = new List<user>()
            {
                new user("",Root.Vip)
                new user("",Root.)
                new user("",Root.)
            }
            celebration = new List<celebratino>
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
