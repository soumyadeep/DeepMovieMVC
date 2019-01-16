using System;
using Microsoft.EntityFrameworkCore;

namespace DeepWebAppMVC.Models
{
    public class PagesMovieContext : DbContext
    {
        public PagesMovieContext(DbContextOptions<PagesMovieContext> options) : base(options)
        {
        }
        public DbSet<DeepWebAppMVC.Models.Movie> Movie { get; set; }
    }
}
