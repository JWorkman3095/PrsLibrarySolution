using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrsLibrary.Models {

    public class PrsDbContext : DbContext {

        //added to link to User after built User Class
        public virtual DbSet<User> Users { get; set;}
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<RequestLine> RequestLines { get; set; }

        //contructors
        //default contructor
        public PrsDbContext() { }
        //contructor w/ parameters
        public PrsDbContext(DbContextOptions<PrsDbContext> options) : base(options) { }

        //Methods
        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            // let it know we are using SQL server
            if (!builder.IsConfigured) //if not cong do it now
                builder.UseSqlServer(
                    "server=localhost\\sqlexpress;database=TestPrsDb;trusted_connection=true"
                    );
        }
        protected override void OnModelCreating(ModelBuilder builder) {
            // makes Username in User unique
            builder.Entity<User>(e => {
                e.HasIndex(p => p.UserName).IsUnique(true); // true is default so could leave blank            
            });                // column
            builder.Entity<Vendor>(e => {
                e.HasIndex(p => p.Code).IsUnique(true); // true is default so could leave blank                                            
            });
            builder.Entity<Product>(e => {
                e.HasIndex(p => p.PartNbr).IsUnique(true); // true is default so could leave blank                                            
            });

        }
    }
}
