﻿using ASyncInn.Models;
using Microsoft.EntityFrameworkCore;

namespace ASyncInn.Data
{
    public class AsyncInnDbContext : DbContext
    {
        public AsyncInnDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }

    }
}
