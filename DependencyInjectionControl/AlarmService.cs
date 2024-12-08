using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionControl
{
    public class AlarmService : IMessageService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Alarm Sent: {message}");
        }
    }
}
