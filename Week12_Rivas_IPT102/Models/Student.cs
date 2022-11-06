using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week12_Rivas_IPT102.Models
{
    public class Student
    {
        [Required]
        public int StudentID { get; set; }

        [Required]
        public string StudentName { get; set; }

        [Range(18,40)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please enter Email ID")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please enter Mobile No")]
        [Display(Name = "Contact Number")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(11, ErrorMessage = "Number not be Exceeded")]
        public int Mobile { get; set; }
    }
}