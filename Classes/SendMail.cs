using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RegIN_Galkins.Classes
{
    public class SendMail
    {
        public static void SendMessage(string Message, string To)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.yandex.ru")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("galkinnikita228@yandex.ru", "ngyfyrwxcwkoxyrr"),
                    EnableSsl = true,
                };

                // Отправка письма
                smtpClient.Send("galkinnikita228@yandex.ru", To, "Проект RegIn", Message);

                Console.WriteLine("Письмо отправлено успешно!");
            }
            catch (SmtpException ex)
            {
                Console.WriteLine($"Ошибка при отправке письма: {ex.Message}");
            }
        }
    }
}