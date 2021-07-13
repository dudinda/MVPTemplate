using System;

using Demo.PresentationLayer.Views;

namespace Demo.UILayer.ConsoleApp.Commands
{
    public class TransientCommand : ITransientFormView
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
            Console.WriteLine("Message from the transient command.");
        }

        public void Tooltip(string msg)
        {
            throw new NotImplementedException();
        }
    }
}
