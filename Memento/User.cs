using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class User
    {
        public string Nombre { get; set; }

        public Memento Save()
        {
            return new Memento(Nombre);
        }

        public void Restore(Memento m)
        {
            Nombre = m.State;
        }
    }
}
