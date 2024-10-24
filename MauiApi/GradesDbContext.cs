using MauiApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration; // Required for IConfiguration
using Microsoft.Extensions.DependencyInjection; // Required for IServiceCollection

namespace MauiApi
{
    public class GradesDbContext : DbContext
    {
        public GradesDbContext(DbContextOptions<GradesDbContext> options) : base(options)
        {
        }

        // Define your DbSet for a table, e.g., Students
        public DbSet<StudentGrade> StudentGrades { get; set; }
    }


}