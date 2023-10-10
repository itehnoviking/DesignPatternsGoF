using Mediator.Abstractions;

namespace Mediator
{
    public class ConcreteMediator : Abstractions.Mediator
    {
        public PaperFactory PaperFactory { get; set; }
        public Printer Printer { get; set; }
        public BookShop BookShop { get; set; }


        public override void Send(string msg, Colleague colleague)
        {
            if (colleague == PaperFactory)
            {
                Printer.MakeBook(msg);
            }

            else if (colleague == Printer)
            {
                BookShop.SellBook(msg);
            }
        }
    }
}