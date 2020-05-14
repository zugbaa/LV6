using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Text;

namespace RPPOON_lv6
{
    class CareTaker
    {
        public  Stack<Memento> previousState;
        public CareTaker()
        {
            previousState = new Stack<Memento>();
        }
        public int Count()
        {
            return previousState.Count;
        }
        public void AddMemento(Memento memento)
        {
            previousState.Push(memento);
        }
        public Memento GetPreviousState()
        {
                return previousState.Pop();
        }

    }

}
