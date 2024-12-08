using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionControl
{
    public interface IMessageService
    {
        void Send(string message);
    }
}
