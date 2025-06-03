using System;
using System.Collections.Generic;

namespace ObserverPattern_WeatherStation
{
    // Observer interface
    public interface IObserver
    {
        void Update(float temperature);
    }

    // Subject interface
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

    // Concrete Subject
    public class WeatherStation : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private float temperature;

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetTemperature(float temp)
        {
            Console.WriteLine($"\n[WeatherStation] Suhu berubah menjadi {temp}°C");
            temperature = temp;
            Notify();
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature);
            }
        }
    }

    // Concrete Observer 1
    public class PhoneDisplay : IObserver
    {
        public void Update(float temperature)
        {
            Console.WriteLine($"[PhoneDisplay] Menampilkan suhu: {temperature}°C");
        }
    }

    // Concrete Observer 2
    public class WindowDisplay : IObserver
    {
        public void Update(float temperature)
        {
            Console.WriteLine($"[WindowDisplay] Update suhu jendela: {temperature}°C");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Membuat subject
            WeatherStation station = new WeatherStation();

            // Membuat observer
            PhoneDisplay phoneDisplay = new PhoneDisplay();
            WindowDisplay windowDisplay = new WindowDisplay();

            // Menambahkan observer ke subject
            station.Attach(phoneDisplay);
            station.Attach(windowDisplay);

            // Simulasi perubahan suhu
            station.SetTemperature(25.5f);
            station.SetTemperature(30.0f);

            // Lepaskan salah satu observer
            station.Detach(windowDisplay);
            Console.WriteLine("\n[INFO] WindowDisplay dilepas dari observer list.\n");

            // Simulasi perubahan suhu lagi
            station.SetTemperature(28.0f);

            Console.ReadKey();
        }
    }
}
