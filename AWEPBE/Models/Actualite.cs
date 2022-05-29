namespace AWEPBE.Models
{
    public class Actualite
    {
        protected int Id { get; set; }
        protected string Title { get; set; }
        protected string ActualiteContent { get; set; }
        protected string Image { get; set; }
        protected bool Active { get; set; }
        protected int AdminId { get; set; }
        protected Admin Admin { get; set; }

    }
}
