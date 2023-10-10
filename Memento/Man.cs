namespace Memento
{
    public class Man
    {
        public string Money { get; set; }
        public void GetMoney(Wallet wallet)
        {
            Money = wallet.Сontents;
        }
        public Wallet PutMoney()
        {
            return new Wallet(Money);
        }
    }

}