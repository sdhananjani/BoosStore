using BookStoreApi.Models.Author;

namespace BookStoreApi.Models.Book
{
    public class BooksReadOnly:BaseDto
    {

        public string Title { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int AuthorId { get; set; }
        public virtual string  AuthorName { get; set; }
    }
}
