namespace BookStoreApi.Models.Author
{
    public class AuthorReadOnlyDto : BaseDto
    {
       
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public string Bio { get; set; }

    }
}
