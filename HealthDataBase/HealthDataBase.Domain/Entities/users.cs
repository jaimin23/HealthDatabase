using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Entities
{
    /// <summary>
    /// Jaimin Patel
    /// This class makes a perticular user 
    /// which also has the properties of a person
    /// since a user IS-A person and user inherits the Person class
    /// </summary>
    public enum TypeOfUsers : byte
    {
        User =1 ,
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
        [Required(ErrorMessage = "Please Select the type of user")]
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
