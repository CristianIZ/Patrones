namespace Observer
{
    public class UserReader : IUserReader
    {
        private List<IChatNotifier> _observers = new List<IChatNotifier>();
        public string Text;

        public void Attach(IChatNotifier observer)
        {
            this._observers.Add(observer);
        }

        public void Detach(IChatNotifier observer)
        {
            this._observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this.Text);
            }
        }
    }
}