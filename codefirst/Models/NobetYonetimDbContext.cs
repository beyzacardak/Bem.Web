using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace codefirst.Models
{
    public class NobetYonetimDbContext: DbContext
    {
        public DbSet<Birim> Birim { get; set; }
        public DbSet<Doktorlar> Doktorlar { get; set; }
        public DbSet<Nobet> Nobet { get; set; }


        public NobetYonetimDbContext():base("Data Source=DESKTOP-S3O5AOR;Initial Catalog=DoktorNobet;Integrated Security=True")
        {
            Database.SetInitializer<NobetYonetimDbContext>(new DbInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Birim>().ToTable("unit");
            modelBuilder.Entity<Doktorlar>().ToTable("doctors");
            modelBuilder.Entity<Nobet>().ToTable("sentry");

            modelBuilder.Entity<Doktorlar>().Property(d => d.Name).HasMaxLength(15);
            modelBuilder.Entity<Birim>().Property(d => d.name).HasMaxLength(20);
            
            base.OnModelCreating(modelBuilder);
            
        }
 
         public class DbInitializer : DropCreateDatabaseAlways<NobetYonetimDbContext>
        {
             protected override void Seed(NobetYonetimDbContext context)
             {
 
                  var dr1 = new Doktorlar
                 {
                     Name = "beyza"
 
                 };
                 var dr2 = new Doktorlar
                 {
                     Name = "seyma"
                 };
 
                context.Doktorlar.Add(dr1);
                 context.Doktorlar.Add(dr2);
 
                 context.SaveChanges();
                 base.Seed(context);
 
             }
         }
 
     }
 } 