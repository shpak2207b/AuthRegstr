using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WpfApp8.Models;

namespace AuthRegstr.Models
{
    public class LoginAppDbContext : DbContext
    {
    private static readonly Department[] departments = [
    new Department() {Id = 1, Location = "Офис 100", Name = "Отдел 1"},
    new Department() {Id = 2, Location = "Офис 200", Name = "Отдел 2"},
    new Department() {Id = 3, Location = "Офис 300", Name = "Отдел 3"}
    ];

    private static readonly ContactInfo[] contacts = [
    new ContactInfo() { Id = 1, Email = "tempEmail1@gmail.com", PhoneNumber = "88005553535" },
    new ContactInfo() { Id = 2, Email = "tempEmail2@gmail.com", PhoneNumber = "88005553535" },
    new ContactInfo() { Id = 3, Email = "tempEmail3@gmail.com", PhoneNumber = "88004443435" }];

    private static readonly WorkStatus[] workStatuses = [
    new WorkStatus() { Id = 1, Status = "Работает" },
    new WorkStatus() { Id = 2, Status = "Уволен" },
    new WorkStatus() { Id = 3, Status = "2-хнедельная отработка" },
    ];

    private static readonly User[] users = [
    new User() {Id = 1, HiredDate = new DateTime(2025,1,15), ContactInfoId = 1,
    DepartmentId = 1, EmployeeId = "EMP-001", WorkStatusId = 1, Position = "Должность 1",
    Salary = 150000, Password = "password1"},
    new User() {Id = 2, HiredDate = new DateTime(2025,1,17), ContactInfoId = 2,
    DepartmentId = 1, EmployeeId = "EMP-002", WorkStatusId = 1, Position = "Должность 2",
    Salary = 120000, Password = "password2"},
    ];

        public DbSet<Department> Departments { get; set; } = null!;
        public DbSet<ContactInfo> ContactInfos { get; set; } = null!;
        public DbSet<WorkStatus> WorkStatuses { get; set; } = null!;

        public DbSet<User> Users { get; set; } = null!;

        public LoginAppDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = database.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Department>().HasData(departments);
            modelBuilder.Entity<ContactInfo>().HasData(contacts);
            modelBuilder.Entity<WorkStatus>().HasData(workStatuses);
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<User>().HasOne(u => u.ContactInfo).WithOne();

        }
    }
}
