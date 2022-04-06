using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcE_Commerce.Infrastructure
{
    public class CmsShoppingCartContext : DbContext

    {
        public CmsShoppingCartContext(DbContextOptions<CmsShoppingCartContext> options) : base(options)
        {
            
        }
    }
}
