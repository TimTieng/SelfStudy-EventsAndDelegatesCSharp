using System;

namespace SelfStudy_EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var report = new Report() { message = "I have an update from one of our tactical elements" };//Insantiate new report class instance 
            var reportEncryptor = new ReportEncryptor();//Instantiate new instance of ReportEncryptor class -- PUBLISHER
            var mailService = new MailService();//Subscriber of the event
            var messageService = new TextMessageService();//New subscriber of textmessage service

            reportEncryptor.ReportEncrypted += mailService.OnReportEncrypted; //Referene or pointer to the OnReportEncrypted Method
            reportEncryptor.ReportEncrypted += messageService.OnReportEncrypted;

            reportEncryptor.Encode(report);
        }
    }
}
