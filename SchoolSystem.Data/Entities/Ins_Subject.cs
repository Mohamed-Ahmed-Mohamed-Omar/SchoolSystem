using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolSystem.Data.Entities
{
    public class Ins_Subject
    {
        public int Id { get; set; }
        public int InsId { get; set; }
        public int SubId { get; set; }

        [ForeignKey(nameof(InsId))]
        [InverseProperty("Ins_Subjects")]
        public Instructor? instructor { get; set; }

        [ForeignKey(nameof(SubId))]
        [InverseProperty("Ins_Subjects")]
        public Subjects? Subject { get; set; }
    }
}
