using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace WebApiRefReshToken.Models
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
        }

        public DbSet<LoginModel> LoginModels { get; set; }
    }
}
