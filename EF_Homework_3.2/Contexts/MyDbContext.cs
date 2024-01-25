using EF_Homework_3._2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Homework_3._2.Contexts
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MSI\\SQLEXPRESS;Initial Catalog=myTask_DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

            base.OnConfiguring(optionsBuilder);
        }


        public DbSet<Curators> Curators { get; set; }
        public DbSet<Department> Deparments { get; set; }
        public DbSet<Faculity> Faculities { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupAndCurator> GroupAndCurators { get; set; }
        public DbSet<GroupAndLecture> GroupAndLectures { get; set; }
        public DbSet<GroupAndStudent> GroupAndStudents { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
