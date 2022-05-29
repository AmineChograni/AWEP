using System.ComponentModel.DataAnnotations.Schema;

namespace AWEPBE.Models
{
    public class EmploiDuTemps
    {
        [ForeignKey("Group")]
        protected int Id { get; set; }
        protected string Label { get; set; }
        protected string EDT { get; set; }
        protected virtual Group Group { get; set; }
        protected int AdminId { get; set; }
        protected Admin Admin { get; set; }
    }
}
