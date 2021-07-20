using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkoutHunter.Models;

namespace WorkoutHunter.Models
{
    public class userContext : DbContext
    {
        public userContext(DbContextOptions<userContext> options) : base(options)
        {

        }

        public DbSet<userInfo> user_info { get; set; }

        public DbSet<userStatus> user_status { get; set; }

    }
}
