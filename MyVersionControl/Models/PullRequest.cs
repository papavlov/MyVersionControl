using System.ComponentModel.DataAnnotations;

namespace MyVersionControl.Models
{
    public class PullRequest
    {
        [Key]
        public int PullRequestId { get; set; }

        [Required]
        public int RepositoryId { get; set; }

        public Repository Repository { get; set; }

        [Required]
        public int AuthorId { get; set; }

        public User Author { get; set; }

        public bool IsResolved { get; set; }

        public List<Commit> Commits { get; set; }
    }
}
