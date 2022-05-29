namespace AWEPBE.Models
{
    public class Offer
    {
        protected int Id { get; set; }
        protected string Label { get; set; }
        protected string OfferContent { get; set; }
        protected bool Statu { get; set; }
        protected int AdminId { get; set; }
        protected Admin Admin { get; set; }
    }
}
