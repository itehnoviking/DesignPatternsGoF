using Iterator.Interfaces;

namespace Iterator
{
    public class Bank : IEnumerable
    {
        private List<Banknote> bankVault = new List<Banknote>
        {
            new Banknote(),
            new Banknote(),
            new Banknote(),
            new Banknote()
        };

        public Banknote this[int index]
        {
            get { return bankVault[index]; }
            set { bankVault.Insert(index, value); }
        }

        public int Count
        {
            get { return bankVault.Count; }
        }

        //реализация интерфейса IEnumerable
        public IEnumerator GetEnumerator()
        {
            return new Cashier(this);
        }
    }
}