using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Sample_Project
{
   public class StateContext:DbContext
    {
        public DbSet<States> State { get; set; }
    }
}
