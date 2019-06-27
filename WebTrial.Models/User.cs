using System;
using System.Collections.Generic;
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
        [Required]
        public string Email { get; set; }

        [Display (Name = "Telephone Number")]
        [Required]
        public int TelephoneNumber { get; set; }


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

