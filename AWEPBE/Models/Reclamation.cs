namespace AWEPBE.Models
{
    public class Reclamation
    {
        protected int Id { get; set; }
        protected string Object { get; set; }
        protected string ReclamationContent { get; set; }
        protected int EtudientId { get; set; }
        protected Etudient Etudient { get; set; }

    }
}
