using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_1.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string Email { get; set; }

        //public Person(string firstName,string lastName, string nickName, string gender, string dob, string email)
        //{
        //    this.FirstName = firstName;
        //    this.LastName = lastName;
        //    this.NickName = nickName;
        //    this.Gender = gender;
        //    this.DOB = dob;
        //    this.Email = email;
        //}
    }
}