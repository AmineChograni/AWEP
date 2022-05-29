namespace AWEPBE.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string OfferContent { get; set; }
        public bool Statu { get; set; }
        public int AdminId { get; set; }
        public Admin Admin { get; set; }
    }
}
