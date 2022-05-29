namespace AWEPBE.Models
{
    public class Tag
    {
        protected int Id { get; set; }
        protected string Label { get; set; }
        protected int LivreId { get; set; }
        protected Livre Livre { get; set; }
    }
}
