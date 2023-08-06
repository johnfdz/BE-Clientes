﻿using Microsoft.EntityFrameworkCore;

namespace API_Clientes.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
