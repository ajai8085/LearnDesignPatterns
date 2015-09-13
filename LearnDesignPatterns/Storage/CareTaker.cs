using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDesignPatterns.Storage
{
    public class CareTaker
    {
        private List<Memento> _mementoes = new List<Memento>();

        public void Add(Memento memento)
        {
            _mementoes.Add(memento);
        }

        public Memento Get(int index)
        {
            return _mementoes[index];
        }
    }
}
