namespace Facade
{
    public class Facade
    {
        private BookCover bookCover;
        private BookPages bookPages;
        private BookText bookText;

        public Facade()
        {
            bookCover = new BookCover();
            bookPages = new BookPages();
            bookText = new BookText();
        }

        public void CreateNewBook()
        {
            Console.WriteLine($"{bookCover.OperationCover()} + {bookPages.OperationPages()} + {bookText.OperationText()} = New Book!");
        }
    }
}