using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSample
{
    [Table("UserInfos")]
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string QQ { get; set; }
        public string Position { get; set; }
        public string FirstLevel { get; set; }
        public string SecondLevel { get; set; }
        public string Mobile { get; set; }
    }
}
