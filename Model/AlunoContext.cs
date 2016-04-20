namespace Model
{
    using System.Data.Entity;

    public partial class AlunoContext : DbContext
    {
        public AlunoContext()
            : base("name=AlunoContext")
        {
        }

        public virtual DbSet<CadAlunoGUILHERME> CadAlunoGUILHERME { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CadAlunoGUILHERME>()
                .Property(e => e.Nome)
                .IsUnicode(false);
        }
    }
}
