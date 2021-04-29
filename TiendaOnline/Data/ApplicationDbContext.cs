using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TiendaOnline.Models;

namespace TiendaOnline.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CategoriaProductos> CategoriaProductos { get; set; }
        public DbSet<Especiales> Especiales { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Orden> Orden { get; set; }
        public DbSet<OrdenDetalles> OrdenDetalles { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<Carrito> Carrito { get; set; }
    }
}
