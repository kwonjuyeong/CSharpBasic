using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BabyCarrotLib.Tools;
using BabyCarrotLib.Extensions;

namespace BabyCarrotTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 로그 매니저 호출
            LogManager log = new LogManager(null, "_BabyCarrotText");

            log.WriteLine("[Begin Processing]-----");

                for (int index = 0; index < 10; index++)
                {
                    log.WriteLine("Processing : " + index);

                    Thread.Sleep(500);

                    log.WriteLine("Done : " + index);
                }

            log.WriteLine("[End Processing]-----");
            */

            /*
            string temp = "12/08/2015 10:10";

            Console.WriteLine("IsNumeric? : " + temp.IsNumeric());
            Console.WriteLine("IsDateTime? : " + temp.IsDateTime());
            */


            //Email Manager 호출
            string contents = "Hello there, <br /> This is Juyeong";

            EmailManager email = new EmailManager("smtp.com", 25, "id", "password");
            email.From = "sender@test.com";
            email.To.Add("receiver@test.com");
            email.Subject = "Subject";
            email.Body = contents;
            email.Send();

            /*
            email.To.Clear();
            email.To.Add("receiver2@test.com");
            email.Subject = "Hi, J";
            email.Send();
            */





        }
    }
}
