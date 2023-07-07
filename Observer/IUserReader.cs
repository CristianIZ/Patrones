using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IUserReader
    {
        void Attach(IChatNotifier observer);
        void Detach(IChatNotifier observer);
        void Notify();
    }
}
