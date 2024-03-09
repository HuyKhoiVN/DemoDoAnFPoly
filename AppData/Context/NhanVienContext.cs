using AppData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Context
{
    public class NhanVienContext:DbContext
    {
        public NhanVienContext()
        {
            
        }

        public NhanVienContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<NhanVien> NhanViens { get; set;}
        public DbSet<ChucVu> ChucVus { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //build sql server
        {
            optionsBuilder.UseSqlServer("Data Source=huykhoilap;Initial Catalog=DoAnDemo;Integrated Security=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
