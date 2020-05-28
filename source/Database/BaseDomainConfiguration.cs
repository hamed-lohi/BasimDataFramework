//using Architecture.Domain;
//using Architecture.Domain.Base;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace Architecture.Database
//{
//    public sealed class BaseDomainConfiguration : IEntityTypeConfiguration<BaseDomain>
//    {
//        public void Configure(EntityTypeBuilder<BaseDomain> builder)
//        {
//            //builder.ToTable("Users", "User");

//            builder.HasKey(based => based.Id);
//            builder.Property(based => based.Id).ValueGeneratedOnAdd().IsRequired();

//            builder.Property(based => based.SInsertDate).HasMaxLength(10);
//            builder.Property(based => based.SInsertTime).HasMaxLength(8);
//            builder.Property(based => based.SUpdateDate).HasMaxLength(10);
//            builder.Property(based => based.SUpdateTime).HasMaxLength(8);
//            builder.Property(based => based.SInsertUser).HasMaxLength(100);
//            builder.Property(based => based.SUpdateUser).HasMaxLength(100);

//        }
//    }
//}
