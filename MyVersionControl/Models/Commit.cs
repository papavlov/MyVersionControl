using System.ComponentModel.DataAnnotations;

namespace MyVersionControl.Models
{
    public class Commit
    {
        [Key]
        public int IssueId { get; set; }

        [Required]
        public string Description { get; set; }

        public string Tags { get; set; }
        public IssueStatus Status { get; set; }
        public int RepositoryId { get; set; }
        public Repository Repository { get; set; }
        public int CreatedById { get; set; }
        public User CreatedBy { get; set; }


    }
}
