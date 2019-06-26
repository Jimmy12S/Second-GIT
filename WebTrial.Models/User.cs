using System;
using System.Collections.Generic;
using System.Text;

namespace WebTrial.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobRole { get; set; }

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

