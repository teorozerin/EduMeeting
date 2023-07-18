using Microsoft.EntityFrameworkCore;

namespace _20230711_EduMeeting.Models
{
    public class DataContext: DbContext
    {

        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meeting>().HasOne(x => x.Category).WithMany(x=>x.Meetings).OnDelete(DeleteBehavior.SetNull);
        }
        public DbSet<Service> Service { get; set; }
        // add-migration ilkMigration

        public DbSet<Category> Category { get; set; }
        //add-migration KategoriTablosuEkle

        public DbSet<Meeting> Meeting { get; set; }
        //add-migration Meeting-->update database

        public DbSet<Education> Education { get; set; }
        //add-migration Education-->update database

        public DbSet<Message> Message { get; set; }
        //add-migration Message-->update database
        public DbSet<SocailMedia> SocailMedia { get; set;}
        //add-migration SosyalMedya
    }
}
