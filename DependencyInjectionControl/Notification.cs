using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionControl
{
    public class Notification
    {
        private readonly IMessageService _messageService;

        public Notification(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Notify(string message)
        {
            _messageService.Send(message);
        }
    }

}
