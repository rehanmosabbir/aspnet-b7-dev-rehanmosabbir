using System.ComponentModel.DataAnnotations;

namespace Library.Areas.Admin.Models
{
    public class BookCreateModel
    {
        [Required]
        public string Name { get; set; }
        public string PublicationName { get; set; }

        internal async Task CreateBook()
        {
            throw new NotImplementedException();
        }
    }
}
