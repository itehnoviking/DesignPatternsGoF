namespace Observer
{
    // Подписчик.
    public delegate void Observer(string state);


    // Издатель.
    public abstract class Subject
    {
        protected Observer observers = null;
        public event Observer Event
        {
            add { observers += value; }
            remove { observers -= value; }
        }
        public abstract string State { get; set; }
        public abstract void Notify();
    }

}