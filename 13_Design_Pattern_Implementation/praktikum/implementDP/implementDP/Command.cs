using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command_dp
{
    public interface ICommand
    {
        void Execute();
    }

    public class Television
    {
        public void TurnOn()
        {
            Console.WriteLine("Television is turned on.");
        }
        public void TurnOff()
        {
            Console.WriteLine("Television is turned off.");
        }
    }

    public class TelevisionTurnOn : ICommand
    {
        private readonly Television? _television;
        public TelevisionTurnOn(Television? television)
        {
            _television = television;
        }
        public void Execute()
        {
            _television!.TurnOn();
        }
    }

    public class TelevisionTurnOff : ICommand
    {
        private readonly Television? _television;
        public TelevisionTurnOff(Television? television)
        {
            _television = television;
        }
        public void Execute()
        {
            _television!.TurnOff();
        }
    }

    public class RemoteTV
    {
        private ICommand? TurnOn;
        private ICommand? TurnOff;

        public void setTurnOn(ICommand? turnOn)
        {
            TurnOn = turnOn;
        }

        public void setTurnOff(ICommand? turnOff)
        {
            TurnOff = turnOff;
        }

        public void pressTurnOn()
        {
            TurnOn!.Execute();
        }

        public void pressTurnOff()
        {
            TurnOff!.Execute();
        }

    }
    class Command
    {
    }
}
