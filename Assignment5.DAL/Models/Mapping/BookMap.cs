using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Assignment5.DAL.Models.Mapping
{
    public class BookMap : EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            // Primary Key
            this.HasKey(t => t.BookID);

            // Properties
            this.Property(t => t.Title)
                .IsRequired();

            this.Property(t => t.Decription)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Books");
            this.Property(t => t.BookID).HasColumnName("BookID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Decription).HasColumnName("Decription");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.DatePublish).HasColumnName("DatePublish");
            this.Property(t => t.AuthorID).HasColumnName("AuthorID");
            this.Property(t => t.Category_ID).HasColumnName("Category_ID");
            this.Property(t => t.Image).HasColumnName("Image");

            // Relationships
            this.HasOptional(t => t.Author)
                .WithMany(t => t.Books)
                .HasForeignKey(d => d.AuthorID);
            this.HasOptional(t => t.Category)
                .WithMany(t => t.Books)
                .HasForeignKey(d => d.Category_ID);

        }
    }
}
