using System;
using System.Collections.Generic;
using System.Text;

namespace EventTemperature
{
   public class SubscriberGUIClient
    {
        // your function should be  the same type of event 
        // your method should be the same type of signature 

        public void TemperatureHasChange(double temp )
        {
            Console.WriteLine("Current temperature:" + temp);
        }
    }
}
