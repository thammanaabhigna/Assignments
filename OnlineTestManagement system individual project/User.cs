//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirstApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "this field is required.")]

        [Display (Name = "User Name")]
        
        public string UserName { get; set; }

        //[Required(ErrorMessage = "this field is required.")]

        //[Display(Name = "User Email")]
        //[DataType(DataType.EmailAddress)]

        public string UserEmail { get; set; }

        [Required(ErrorMessage = "this field is required.")]
        [DataType(DataType.Password)]

        [Display(Name = "User Password")]
        public string UserPassword { get; set; }

        //[Required(ErrorMessage = "this field is required.")]

      
        public string Gender { get; set; }

        //[Required(ErrorMessage = "this field is required.")]

       
        public string ContactNumber { get; set; }
    }
}
