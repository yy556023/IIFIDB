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

        public DbSet<user_Info> user_Info { get; set; }

        public DbSet<WorkoutHunter.Models.user_Status> user_Status { get; set; }

        public DbSet<Student> testV { get; set; }
    }
}
