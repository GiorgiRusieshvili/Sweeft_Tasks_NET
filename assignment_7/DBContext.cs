using System.Data.Entity;

namespace assignment_7
{
    internal class DBContext : DbContext
    {
        public DbSet<Pupil> Pupils { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pupil>()
                    .HasMany<Teacher>(s => s.Teacher)
                    .WithMany(t => t.Pupils)
                    .Map(st =>
                    {
                        st.MapLeftKey("StudentId");
                        st.MapRightKey("TeacherId");
                        st.ToTable("StudentTeacher");
                    });
        }
    }
}
