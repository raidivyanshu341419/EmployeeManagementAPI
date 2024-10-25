using EmployeeManagement.DbModel;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.DbCon
{
    public class EmployeeContext : DbContext

    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }
        public DbSet<ParentDepartment> ParentDepartments{ get; set; }
        public DbSet<ChildDepartment> ChildDepartments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(x => x.EmployeeId); // For primary key on the user table, Id column.

                entity.Property(x => x.EmployeeName)
                .ValueGeneratedOnAdd(); // Optional : Configure Id to auto-increment

            });
            modelBuilder.Entity<ParentDepartment>(entity =>
            {
                entity.HasKey(x => x.DepartmentId); // For primary key on the user table, Id column.
                
                entity.Property(x => x.DepartmentId)
                .ValueGeneratedOnAdd(); // Optional : Configure Id to auto-increment

            });
            
            modelBuilder.Entity<ChildDepartment>()
             .HasOne(cd => cd.ParentDepartment)           // Each ChildDepartment has one ParentDepartment
             .WithMany(pd => pd.ChildDepartments)         // Each ParentDepartment has many ChildDepartments
             .HasForeignKey(cd => cd.ParentDepartmentId)  // The foreign key is ParentDepartmentId in ChildDepartment
             .OnDelete(DeleteBehavior.Cascade);           // Optional: Define cascading delete behavior
        }
    }
}
