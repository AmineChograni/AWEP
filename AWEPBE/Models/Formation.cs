namespace AWEPBE.Models
{
    public class Formation
    {
        protected int Id { get; set; }
        protected string Label { get; set; }
        protected string Description { get; set; }
        protected string Image { get; set; }
        protected FormationType TypeFormation { get; set; }
        protected virtual Certification CertificationId { get; set; }
        protected int AdminId { get; set; }
        protected Admin Admin { get; set; }

    }
}
