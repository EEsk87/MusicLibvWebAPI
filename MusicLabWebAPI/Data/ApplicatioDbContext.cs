using System;
using Microsoft.EntityFrameworkCore;
using MusicLabWebAPI.Models;

namespace MusicLabWebAPI.Data
{
	public class ApplicationDbContext : DbContext
	{ 
	
        public DbSet<Song> Songs { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
			
		{

		}
	}
}

