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
    public class ReportEventArgs : EventArgs
    {
        public Report Report { get; set; }
    }
    public class ReportEncryptor
    {
        //Step 1  - Define a Delegate
        public delegate void ReportEncryptedEventHandler(object source, ReportEventArgs args);
        //Step 2 - define an event based off that delegate
        public event ReportEncryptedEventHandler ReportEncrypted;//This shows that the event has been completed (past tense Name)
        //Step 3 - Raise the Event utilizing a method


        public void Encode(Report report)
        {
            Console.WriteLine("Encrypting Report...");
            Thread.Sleep(3000);//This pauses the program for a certain amount of time. This is used to simulate the encryption process


            //Raise the event by calling the method
            OnReportEncrypted(report);
        }
        //Method that will be used to raise the event
        protected virtual void OnReportEncrypted(Report report)//Event raising methods start with "On"
        {
            if (ReportEncrypted != null)
                ReportEncrypted(this, new ReportEventArgs() { Report = report});
        }
    }
}
