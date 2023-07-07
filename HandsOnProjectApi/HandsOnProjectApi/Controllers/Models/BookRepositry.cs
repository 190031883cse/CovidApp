namespace HandsOnProjectApi.Controllers.Models
{
    public interface Ibookrepositry
    {
        void AddBooks(Book book);
        Book GetBook(int BookId);

        void DeleteBook(int BookId);
       
    }

    public class BookRepositry : Ibookrepositry
    {
        public static List<Book> books = new List<Book>()
        { 
            new Book() {BookId=1,Name="truth",Price=100,Author="censys",Publisher="knk"},
            new Book() {BookId=2,Name="rich dad poor dad",Price=1111,Author="censys",Publisher="knk"},
            new Book() {BookId=3,Name="yes",Price=100,Author="censys",Publisher="knk"},

        };

        public void AddBooks(Book book)
        {
            books.Add(book);
        }

        public void DeleteBook(int BookId)
        {
            Book book = books[BookId];
                books.Remove(book);
        }

        public Book GetBook(int BookId)
        {
            return books.SingleOrDefault(book => book.BookId == BookId);
            
        }
    }
}
