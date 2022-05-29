namespace AWEPBE.Models
{
    public class Group
    {
        protected int Id { get; set; }
        protected string Label { get; set; }
        protected string FiliereId { get; set; }
        protected Filiere Filiere { get; set; }
        protected virtual EmploiDuTemps EmploiDuTemps { get; set; }
    }
}
