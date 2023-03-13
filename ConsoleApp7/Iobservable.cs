using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    interface Iobservable
    {
        void Addobserver(Iobserver o);
        void RemoveObserver(Iobserver o);
        void NotifyObserver();
    }
}
