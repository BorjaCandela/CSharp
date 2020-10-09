using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Timers;

namespace HeartBeath
{
    class Program
    {
        private static Timer aTimer;
        public static void Main(string[] args)
        {
            SetTimer();
            Console.WriteLine("\nPress the Enter key to exit the application...\n");
            Console.ReadLine();
            aTimer.Stop();
            aTimer.Dispose();
        }
        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new Timer(2000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += pingMethod;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private static void pingMethod(Object source, ElapsedEventArgs e)
        {
            Ping pingObject = new Ping();
            PingReply pingReply;
            string ipDesti;
            ipDesti = "127.0.0.1";
            pingReply = pingObject.Send(ipDesti);

            if (pingReply.Status == IPStatus.Success)
            {
                Console.WriteLine("Ping OK");
            }
            else
            {
                Console.WriteLine("Ping not OK");
                using (EventLog eventLog = new EventLog("Application"))
                {
                    eventLog.Source = "Application";
                    eventLog.WriteEntry("Event Thrown at ping failure", EventLogEntryType.Error, 555, 1);
                }
            }
            pingObject.Dispose();
            GC.Collect();
        }
    }
}
