using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCSupermarketOrnek.Data
{
    public class MVCSupermarketOrnekContext : DbContext
    {
        public MVCSupermarketOrnekContext (DbContextOptions<MVCSupermarketOrnekContext> options)
            : base(options)
        {
        }

        public DbSet<MVCSupermarketOrnek.Data.Urun> Urun { get; set; } = default!;
    }
}
