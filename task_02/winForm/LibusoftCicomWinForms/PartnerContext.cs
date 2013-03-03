using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibusoftCicomWinForms
{
    class PartnerContext : DbContext
    {
        public DbSet<Partner> Partners { get; set; }
    }
}
