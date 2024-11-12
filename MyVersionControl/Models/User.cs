using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MyVersionControl.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        public List<Repository> Repositories { get; set; }

        public List<Commit> Commits { get; set; }
        
        public List<Issue> Issues {  get; set; }
        
        public List<PullRequest> PullRequests { get; set; }


        public List<Repository> ContributedRepositories { get; set; }


    }
}
