using System.ComponentModel.DataAnnotations.Schema;

namespace AWEPBE.Models
{
    public class Certification
    {
        [ForeignKey("Formation")]
        protected int Id { get; set; }
        protected string Label { get; set; }
        protected string Description { get; set; }
        protected string Image { get; set; }
        protected virtual Formation Formation { get; set; }
        protected CertificationType TypeCertification { get; set; }
    }
}
