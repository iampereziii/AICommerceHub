using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace AICommerceHub.Data.Context
{
    public class AICommerceHubContext : IdentityDbContext // TODO replace to identity later on
    {
        public AICommerceHubContext(DbContextOptions<AICommerceHubContext> options)
        : base(options)
        {
        }

    }
}
