namespace AWEPBE.Models
{
    public class Note
    {
        protected int Id { get; set; }
        protected string Label { get; set; }
        protected string NoteFile { get; set; }
        protected int EvaluationId { get; set; }
        protected Evaluation Evaluation { get; set; }
        protected int EtudientId { get; set; }
        protected Etudient Etudient { get; set; }


    }
}
