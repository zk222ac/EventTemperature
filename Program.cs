using System;

namespace EventTemperature
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                PublisherTemperatureMonitor monitor = new PublisherTemperatureMonitor();
                SubscriberGUIClient client = new SubscriberGUIClient();

                // Register your subscriber method (TemperatureHasChange) to the delegate event name (TemperatureChangeEvent)

                monitor.TemperatureChangeEvent += client.TemperatureHasChange;

                // Monitor method

                monitor.MonitorDevice();

            }



            Console.ReadKey();
        }
    }
}
