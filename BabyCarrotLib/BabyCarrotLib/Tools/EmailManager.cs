using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BabyCarrotLib.Tools
{
    public class EmailManager
    {

        public static void Send(string to, string subject, string contents)
        {
            string sender = ConfigurationManager.AppSettings["SMTPSender"];

            string smtpHost = ConfigurationManager.AppSettings["SMTPHost"];

            int smtpPort = 0;

            //조건에 맞지 않으면 기본 포트 부여
            if (ConfigurationManager.AppSettings["SMTPPort"] == null || int.TryParse(ConfigurationManager.AppSettings["SMTPPort"], out smtpPort) == false)
                smtpPort = 25;


            //Host와 Port번호로 아무나 와서 스팸 메일을 계속해서 보낸다면 블랙 리스트에 올라 해당 서버에서 전송되는 메일이 차단되게 되는 현상을 막기 위함. 
            string smtpId = ConfigurationManager.AppSettings["SMTPID"]; ;
            string smtpPwd = ConfigurationManager.AppSettings["SMTPPassword"]; ;

            //Package
            MailMessage mailMsg = new MailMessage();
            mailMsg.From = new MailAddress(sender);
            mailMsg.To.Add(new MailAddress(to));
            
            mailMsg.Subject = subject;
            mailMsg.IsBodyHtml = true;
            mailMsg.Body = contents;
            mailMsg.Priority = MailPriority.Normal;
            //

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(smtpId, smtpPwd);
            smtpClient.Host = smtpHost;
            smtpClient.Port = smtpPort;
            smtpClient.Send(mailMsg);



        }


    }
}
