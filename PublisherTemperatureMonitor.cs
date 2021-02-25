using System;
using System.Collections.Generic;
using System.Text;

namespace EventTemperature
{
    // simple delegate
    // one input parameter
    // void return type --> output
    //public delegate void TemperatureDelegate(double temp);

    // The pupose of this class is to raise an Event
  public  class PublisherTemperatureMonitor
    {
        // Event 
        // event is special keyword in C# which is define the event
        // TemperatureChangeEvent : name of event
        // TemperatureDelegate is a type of delegate of event
        //public event TemperatureDelegate TemperatureChangeEvent;
        // How you can imgae that this delegate built in function are very powerfull

        #region Event 
        public event Action<double> TemperatureChangeEvent;
        #endregion

        #region Instance Field
        private double _temperature;
        #endregion

        #region Costructor 
        public PublisherTemperatureMonitor()
        {
            TemperatureChangeEvent = null;
        }
        #endregion

        #region Normal Methods
        public void MonitorDevice()
        {
            // sensor device broadcasting temp data
            double randomTemp = GetTempFromDevice();

            if(randomTemp < 10 || randomTemp > 25)
            {
                _temperature = randomTemp;

                // Raise an Event method
                OnTemperatureChangeEvent();
            }
        }

        public double GetTempFromDevice()
        {
            Random ran = new Random();
            return ran.Next(1, 50);
        }

        #endregion

        #region Raise Event Method
        protected virtual void OnTemperatureChangeEvent()
        {
            Console.WriteLine("Warning situation is occured");
            TemperatureChangeEvent?.Invoke(_temperature);
        }
        #endregion


    }
}
