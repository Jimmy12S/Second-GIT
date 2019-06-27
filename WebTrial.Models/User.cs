using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebTrial.Models
{
    public class User : BaseEntity
    {
        [Display (Name= "First Name")]
        public string FirstName { get; set; }
        [Display (Name= "Last Name")]
        public string LastName { get; set; }
        [Display (Name= "Job Role")]
        public string JobRole { get; set; }
        
        //[Display(Name = "Email Address")]
        //[Required(ErrorMessage = "The email address is required")]
        //[EmailAddress(ErrorMessage = "Invalid Email Address")]
        //[DataType (DataType.EmailAddress)]
        //public string EmailAddress { get; set; }

        //[Display (Name = "Telephone Number")]
        //[Required]
        //public string TelephoneNumber { get; set; }


        //public User(int id, string firstname, string lastname, string jobrole)
        //{
        //    this.ID = id;
        //    this.FirstName = firstname;
        //    this.LastName = lastname;
        //    this.JobRole = JobRole;
        //}

        //public void GetUserDetail()
        //{
        // Console.WriteLine($" ID {0},FirstName: {1}, LastName:{2}, JobRole: {3}, ID, FirstName, LastName, JobRole");
        //}


    }
    }

