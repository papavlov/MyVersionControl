using System.ComponentModel.DataAnnotations;

namespace MyVersionControl.Models
{
    public class Repository
    {
        [Key]
        public int RepositoryId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        public bool IsPrivate { get; set; }

        public int OwnerId { get; set; }

        public User Owner { get; set; }

        public List<User> Contributors { get; set; }
        public List<Commit> Commits { get; set; }
        public List<Issue> Issues { get; set; }
        public List<PullRequest> PullRequests { get; set; }



    }
}
