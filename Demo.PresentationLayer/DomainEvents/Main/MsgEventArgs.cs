namespace Demo.PresentationLayer.DomainEvents.Main
{
    public class MsgEventArgs : BaseEventArgs
    {
        public MsgEventArgs(string msg)
        {
            Message = msg;
        }

        public string Message { get; }
    }
}
