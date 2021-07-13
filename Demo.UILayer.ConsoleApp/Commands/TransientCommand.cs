using System;

using Demo.PresentationLayer.Views;

namespace Demo.UILayer.ConsoleApp.Commands
{
    class TransientCommand : ITransientFormView
    {
        public void Close()
        {
            throw new NotImplementedException();
        }

        public bool Focus()
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            Console.WriteLine("Transient command is running...");
        }

        public void Tooltip(string msg)
        {
            throw new NotImplementedException();
        }
    }
}
