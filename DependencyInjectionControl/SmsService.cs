using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionControl
{
    public class SmsService : IMessageService
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS Sent: {message}");
        }
    }

}
