using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDesignPatterns.Storage
{
    public class Originator
    {
        public string Article { get; set; }
        public void Set(string newArticle)
        {
            Article = newArticle;
        }

        public Memento StoreInmemento()
        {
            return new Memento(Article);
        }

        public string RestoreFrom(Memento memento)
        {
            Article = memento.Article;
            return Article;
        }
    }
}
