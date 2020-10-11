/*
Student: Tim Tieng
Date: 11 October 2020
Description: Self Study, Events Handling and Delegates in C#
References: Followed the video lesson provided by "Programmming with Mosh"
https://www.youtube.com/watch?v=jQgwEsJISy0 
*/

using System;

namespace SelfStudy_EventsAndDelegates
{
    public class MailService
    {
        //Reference the delegate
        public void OnReportEncrypted(object source, ReportEventArgs e)
        {
            Console.WriteLine("MailService: Sending Encrypted Email Now. " + e.Report.message);
        }
    }
}
