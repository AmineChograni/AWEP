namespace AWEPBE.Models
{
    public class Mail
    {
        protected int Id { get; set; }
        protected string EnvoyeVers { get; set; }
        protected string Object { get; set; }
        protected string MailContent { get; set; }
        protected int AdminId { get; set; }
        protected Admin Admin { get; set; }

    }
}
