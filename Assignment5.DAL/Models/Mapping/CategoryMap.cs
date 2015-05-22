using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Assignment5.DAL.Models.Mapping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.Category_ID);

            // Properties
            this.Property(t => t.Category_Name)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Categories");
            this.Property(t => t.Category_ID).HasColumnName("Category_ID");
            this.Property(t => t.Category_Name).HasColumnName("Category_Name");
        }
    }
}
