using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Assignment5.DAL.Models.Mapping
{
    public class CommentMap : EntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            // Primary Key
            this.HasKey(t => t.CommentID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Comments");
            this.Property(t => t.CommentID).HasColumnName("CommentID");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.BookID).HasColumnName("BookID");
            this.Property(t => t.UserId).HasColumnName("UserId");

            // Relationships
            this.HasOptional(t => t.Book)
                .WithMany(t => t.Comments)
                .HasForeignKey(d => d.BookID);
            this.HasOptional(t => t.User)
                .WithMany(t => t.Comments)
                .HasForeignKey(d => d.UserId);

        }
    }
}
