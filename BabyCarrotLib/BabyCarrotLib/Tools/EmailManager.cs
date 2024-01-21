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

        private MailMessage _MailMessage;
        private SmtpClient _SmtpClient;

        public EmailManager(string host, int port, string id, string password)
        {
            _SmtpClient = new SmtpClient(host, port);
            _SmtpClient.Credentials = new NetworkCredential(id, password);

            _MailMessage = new MailMessage();
            _MailMessage.IsBodyHtml = true;
            _MailMessage.Priority = MailPriority.Normal;

            // 첨부파일 추가
            // _MailMessage.Attachments.Add(new Attachment());
        
        }

        public string From
        {
            get { return _MailMessage.From == null ? String.Empty : _MailMessage.From.Address; }
            set { _MailMessage.From = new MailAddress(value); }
        }

        public MailAddressCollection To
        {
            get { return _MailMessage.To; }
        }

        public string Subject
        {
            get { return _MailMessage.Subject; }
            set { _MailMessage.Subject = value;}

        }

        public string Body
        {
            get { return _MailMessage.Subject; }
            set { _MailMessage.Subject = value;}
        }

        public void Send()
        {
            _SmtpClient.Send(_MailMessage);
        }


        #region Static Methods
        public static void Send(string from, string to, string subject, string contents, string cc, string bcc)
        {
            if (String.IsNullOrEmpty(from))
                throw new ArgumentNullException("Sender is empty.");
            if(String.IsNullOrEmpty(to)) 
                throw new ArgumentNullException("To is empty");


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
            mailMsg.From = new MailAddress(from);
            mailMsg.To.Add(new MailAddress(to));


            //"CC"는 일반적으로 여러 이메일 주소를 저장할 수 있는 컬렉션으로, 메시지를 참조로 받을 수 있는 추가 수신자를 나타냄.
            if (!!String.IsNullOrEmpty(cc))
                mailMsg.CC.Add(cc);
            //"Bcc"는 메시지를 받는 수신자에게는 전달되지만, 이들의 이메일 주소는 다른 수신자에게는 보이지 않는 용도
            if (!String.IsNullOrEmpty(bcc))
                mailMsg.Bcc.Add(bcc);

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

        public static void Send(string from, string to, string subject, string contents)
        {
            Send(from, to, subject, contents, null, null);
        }


        public static void Send(string to, string subject, string contents)
        {
            string sender = ConfigurationManager.AppSettings["SMTPSender"];
            Send(sender, to, subject, contents);
        }
        #endregion

    }
}
