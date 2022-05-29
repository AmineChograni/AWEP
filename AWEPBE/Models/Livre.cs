using System.Collections.Generic;

namespace AWEPBE.Models
{
    public class Livre
    {
        protected int Id { get; set; }
        protected string Title { get; set; }
        protected string LivreFile { get; set; }
        protected int AdminId { get; set; }
        protected Admin Admin { get; set; }
        protected ICollection<Tag> Tags { get; set; }
    }
}
