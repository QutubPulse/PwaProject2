using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwaProject2.Shared
{
    public class UserSessionDetail
    {
        [Key]
        public int? inId { get; set; }
        public int inUserId { get; set; }
        public string stSessionId { get; set; }
        public bool flgIsActive { get; set; }
        public string stBrowserName { get; set; }
        public string stIpAddress { get; set; }
    }
}
