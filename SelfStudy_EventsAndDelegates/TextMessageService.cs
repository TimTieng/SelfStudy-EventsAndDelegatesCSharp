/*
Student: Tim Tieng
Date: 11 October 2020
Description: Self Study, Events Handling and Delegates in C#
References: Followed the video lesson provided by "Programmming with Mosh"
https://www.youtube.com/watch?v=jQgwEsJISy0 
*/
using System;

using System.Threading;

namespace SelfStudy_EventsAndDelegates
{
    public class TextMessageService
    {
        public void OnReportEncrypted(object source, ReportEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a encrypted text message now. " + args.Report.message);
        }
    }
}
