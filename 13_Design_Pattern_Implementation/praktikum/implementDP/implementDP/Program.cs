using singleton_dp;
using adapter_dp;
using command_dp;

namespace design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================= Singleton =========================");
            Rektor rektor1 = Rektor.GetRektor();
            Rektor rektor2 = Rektor.GetRektor();

            if (rektor1 == rektor2)
            {
                Console.WriteLine("Kedua rektor adalah sama!");
            }
            else
            {
                Console.WriteLine("Kedua rektor berbeda!");
            }

            rektor1.tandaTangan();

            Console.WriteLine("========================= Adapter =========================");
            IndonesianPlug indonesianPlug = new IndonesianPlug();
            IAmericanPlug adaptor = new PlugAdaptor(indonesianPlug);
            adaptor.Plugin();

            Console.WriteLine("========================= Command =========================");
            RemoteTV remote = new RemoteTV();
            Television tv = new Television();

            TelevisionTurnOn turnOn = new TelevisionTurnOn(tv);
            TelevisionTurnOff turnOff = new TelevisionTurnOff(tv);

            remote.setTurnOn(turnOn);
            remote.setTurnOff(turnOff);
            remote.pressTurnOn();
            remote.pressTurnOff();
        }
    }
}