﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Entities
{
    public enum TypeOfUsers : byte
    {
        User,
        Admin,
        Doctor
    }
    public class users: Person
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Please enter your Username")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter your Password")]
        public string UserPassword { get; set; }
        public TypeOfUsers UserType { get; set; }

        public void Change(users user)
        {
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.EmailAddress = user.EmailAddress;
            this.PhoneNumber = user.PhoneNumber;
            this.UserName = user.UserName;
            this.UserPassword = user.UserPassword;
            this.UserType = user.UserType;
        }
    }
}
