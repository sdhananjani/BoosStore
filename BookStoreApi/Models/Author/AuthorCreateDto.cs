using System.ComponentModel.DataAnnotations;

namespace BookStoreApi.Models.Author
{
    public class AuthorCreateDto: BaseDto
    {
       
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LasttName { get; set; }
       
        [StringLength(250)]
        public string Bio { get; set; }
    }
}
