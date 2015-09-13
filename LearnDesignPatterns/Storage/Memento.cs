using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDesignPatterns.Storage
{

   public  class Memento
    {
       public string Article { get; private set; }
       public Memento(string article)
       {
           Article = article;
       }

    }
}
