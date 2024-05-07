using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace traingbackendc_.Data
{
    public class ApplicationDbcontext:Dbcontext
    {
        public ApplicationDbcontext(DbConnection<ApplicationDbcontext> options):base(options)
        {

        }
        public Dbset<User> Users { get; set; }
    }
}dadd