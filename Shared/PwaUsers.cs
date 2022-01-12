using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwaProject2.Shared
{
    public class PwaUsers
    {
        [Key]
        public int? inUserId { get; set; }
        public Guid unUserId { get; set; }
        public string stFirstName { get; set; }
        public string stLastName { get; set; }

    }
}
