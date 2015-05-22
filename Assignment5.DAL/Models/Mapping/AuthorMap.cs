using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Assignment5.DAL.Models.Mapping
{
    public class AuthorMap : EntityTypeConfiguration<Author>
    {
        public AuthorMap()
        {
            // Primary Key
            this.HasKey(t => t.AuthorID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Authors");
            this.Property(t => t.AuthorID).HasColumnName("AuthorID");
            this.Property(t => t.AuthorName).HasColumnName("AuthorName");
        }
    }
}
