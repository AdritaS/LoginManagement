using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LoginManagement.Data
{
    [Table("Roles")]
    public class Role 
    {
        public Role()
        {
            UserRoles = new List<UserRole>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid RoleId { get; set; }

        [Column("Role")]
        [MaxLength(50)]
        public string RoleName { get; set; }

        [MaxLength(10)]
        [Column("Abbreviation")]
        public string RoleAbbreviation { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
