using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSample
{
    public class MonitorDBContext : DbContext
    {
        public MonitorDBContext(string connectionString)
            : base(connectionString)
        {
        }

        public IDbSet<User> Users { get; set; }
    }
}
