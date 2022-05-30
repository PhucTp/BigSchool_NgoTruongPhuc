using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool_NgoTruongPhuc.Models
{
    public class Course
    {   

        public int ID { get; set; } 
        public ApplicationUser Lecturer { get; set; }
        [Required] 
        public string LecturerId { get; set; }
        [Required]
        [StringLength(255)] 
        public string Place 
        
        
    }
}