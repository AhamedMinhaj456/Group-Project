using GUI_Project.Model;
using GUI_Project.Model.NewFolder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project
{
    public partial class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }

        public DataBaseContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\Computer Solution\\Desktop\\GUI_Project _New\\GUI_Project\\GUI_Project\\user.db");
        }

        //private readonly string path = @"C:\Users\Computer Solution\Desktop\GUI_Project\database1.db";

        //protected override void OnConfiguring(DbContextOptionsBuilder
        //    optionsBuilder) => optionsBuilder.UseSqlite
        //    ($"Data Source={path}");

        public DbSet<CreateUserCls>? UserCls { get; set; }
        public DbSet<CreateAdminCLs>? AdminCLs { get; set; }
        public DbSet<RegistrationCls>? registrations { get; set; }
        public DbSet<RegistrationCls2>? registration_2s { get; set; }
        public DbSet<AdmitPatientPageCls>? AdmitPatientPageCls { get; set; }
        public DbSet<AddDoctorPageCls>? addDoctorPageCls { get; set; }
        public DbSet<AddMedicineCls>? addMedicineCls { get; set; }
        public DbSet<AddStaffClass>? addStaffCls { get; set; }
        public DbSet<SupplierCls>? supplierCls { get; set; }
        public DbSet<AddTestCls>? addTestCls { get; set; }
        public DbSet<ReleasePatientClass>? releasePatientClasses { get; set; }


        // Comboxes
        public DbSet<ComboBoxDiseaseType> comboBoxDiseaseTypes { get; set; }
        public DbSet<ComboBoxDiseaseName> comboBoxDiseaseNames { get; set; }
        public DbSet<ComboBoxBloodGroup> comboBoxBloodGroups { get; set; }
        public DbSet<ComboBoxDepartment> comboBoxDepartments { get; set; }





        //public DbSet<AdminDetails> AdminDetails { get; set; }
        //public DbSet<UserLogin> UserLogins { get; set; }
        //public DbSet<UserDetails> UserDetails { get; set; }








    }
}
