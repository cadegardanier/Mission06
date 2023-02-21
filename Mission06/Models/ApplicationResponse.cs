using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int applicationID { get; set; }
        [Required]

        //foreign key
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "Please select a Category")]
        public Category Category { get; set; }
        


        [Required(ErrorMessage = "Please input a Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please input a Year")]

        public short Year { get; set; }
        [Required(ErrorMessage = "Please input a Director")]

        public string Director { get; set; }
        [Required(ErrorMessage = "Please input a Rating")]

        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string Lent { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }

    }
}
