using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionControl
{
    class Program
    {
        static void Main(string[] args)
        {
            // Email ile bildirim gönderme
            IMessageService emailService = new EmailService();
            Notification emailNotification = new Notification(emailService);
            emailNotification.Notify("Notify with Email!");

            // SMS ile bildirim gönderme
            IMessageService smsService = new SmsService();
            Notification smsNotification = new Notification(smsService);
            smsNotification.Notify("Notify with SMS!");

            // Alarm ile bildirim gönderme
            IMessageService alarmService = new AlarmService();
            Notification alarmNotification = new Notification(alarmService);
            alarmNotification.Notify("Notify with Alarm!");
        }
    }
}

