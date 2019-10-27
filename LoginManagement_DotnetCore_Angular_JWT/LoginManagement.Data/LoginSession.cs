using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LoginManagement.Data
{
    [Table("LoginSessions")]
    public class LoginSession
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LoginSessionId { get; set; }
        public DateTime LoginDate { get; set; }
        public string Description { get; set; }
        public string IpAddress { get; set; }
        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
