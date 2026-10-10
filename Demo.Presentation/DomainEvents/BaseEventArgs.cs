using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Presentation.DomainEvents
{
    public abstract class BaseEventArgs 
    {
        public DateTime PublishedOn { get; }

        protected BaseEventArgs()
        {
            PublishedOn = DateTime.Now;
        }
    }
}
