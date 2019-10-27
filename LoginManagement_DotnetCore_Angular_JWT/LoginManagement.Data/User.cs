using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginManagement.Data
{
    [Table("Users")]
    public class User { 
        public User()
        {
            LoginSessions = new List<LoginSession>();
            UserRoles = new List<UserRole>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string PhoneNumber { get; set; }
        public int AccessFailedCount { get; set; }
        public virtual ICollection<LoginSession> LoginSessions { get; set; }
        public virtual List<UserRole> UserRoles { get; set; }
        public string FullName() => (!string.IsNullOrEmpty(MiddleName)) ? $"{FirstName} {MiddleName} {LastName}"?.Trim() : $"{FirstName} {LastName}";
        public string ReverseFullName() => (!string.IsNullOrEmpty(MiddleName)) ? $"{LastName} {MiddleName} {FirstName}"?.Trim() : $"{LastName} {FirstName}";

    }
}
