using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace first_aspnet_webapp.Models
{
    public class GradeModel
    {
        [Required]
        [Range(typeof(int), "0", "100")]
        public int assignments { get; set; }
        [Required]
        [Range(typeof(int), "0", "100")]
        public int group_project { get; set; }
        [Required]
        [Range(typeof(int), "0", "100")]
        public int quizzes { get; set; }
        [Required]
        [Range(typeof(int), "0", "100")]
        public int intex { get; set; }

        public string Output { get; set; }
    }
}

