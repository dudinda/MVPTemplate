﻿
using System;

using Demo.PresentationLayer.Views;

namespace Demo.UILayer.ConsoleApp.Commands
{
    public class SingletonCommand : ISingletonFormView
    {
        public void Close()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public bool Focus()
        {
            throw new System.NotImplementedException();
        }

        public void Show()
        {
            Console.WriteLine("Message from the singleton command.");
        }

        public void Tooltip(string msg)
        {
            throw new System.NotImplementedException();
        }
    }
}
