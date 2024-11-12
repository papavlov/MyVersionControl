using System.ComponentModel.DataAnnotations;

namespace MyVersionControl.Models
{
    public class Modification
    {

        [Key]
        public int ModificationId { get; set; }

        public string FileName { get; set; }
        public string FileDifferences { get; set; }
        public ModificationType Type { get; set; }

        public int CommitId { get; set; }
        public Commit Commit { get; set; }
    }
}
