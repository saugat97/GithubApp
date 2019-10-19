using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GithubApp.Models
{
    public class Repo
    {
        public int Id { get; set; }
        public string Node_id { get; set; }
        public string Name { get; set; }
        public string Full_name { get; set; }
        public bool Private { get; set; }
        public string Html_url { get; set; }
        public string Description { get; set; }
        public string Stargazers_count { get; set; }
        public string Created_at { get; set; }
        public string Updated_at { get; set; }
        public string Git_url { get; set; }
        public string Ssh_url { get; set; }
        public Owner Owner { get; set; }

    }

    public class Owner
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Url { get; set; }

    }

    public class Repositories
    {
        public int Total_count { get; set; }
        public bool Incomplete_results { get; set; }
        public List<Repo> Items { get; set; }
    }
}