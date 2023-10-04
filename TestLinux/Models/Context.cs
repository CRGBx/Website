using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestLinux.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }

        public DbSet<Grievance> Grievances { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<EmployeeMaster> EmployeeMasters { get; set; }
        public DbSet<BranchMaster> Branches { get; set; }

        public DbSet<OTP> OTPs { get; set; }
        public DbSet<UserProfile> Employee { get; set; }
        public DbSet<AttendanceProfie> Attendances { get; set; }

        public DbSet<LearningData> Learnings { get; set; }
        public DbSet<DeafData> Deafs { get; set; }

        public DbSet<Logs> Logs { get; set; }

        public DbSet<VisitRemark> VisitRemarks { get; set; }
        public DbSet<PreVisitRemark> PreIsnpectionRemarks { get; set; }
        public DbSet<PostVisitRemark> PostIsnpectionRemarks { get; set; }
        public DbSet<PostInspection> PostInspections { get; set; }
        public DbSet<PreInspection> PreInspection { get; set; }
        public DbSet<CSPVisit> CSPVisits { get; set; }
        public DbSet<ValueStatement> CSPValueStatements { get; set; }
        public DbSet<PreValueStatement> PreInspectionValueStatements { get; set; }
        public DbSet<PostValueStatement> PostInspectionValueStatements { get; set; }

        public DbSet<BranchPerformance> BranchPerformances { get; set; }

        public DbSet<Csp> Csps { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                if (entity?.GetTableName() != null)
                {
                    entity.SetTableName(entity.GetTableName()?.ToLower());
                }
            }
        }
    }
}
