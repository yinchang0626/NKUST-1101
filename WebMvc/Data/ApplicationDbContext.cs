using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebMvc.Models;

namespace WebMvc.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Activity> Activities { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
