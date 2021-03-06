// <auto-generated />
using System;
using Koala.DAL.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Koala.DAL.Migrations
{
    [DbContext(typeof(SqlContext))]
    [Migration("20220309134526_Event1")]
    partial class Event1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Koala.DAL.Entities.Event", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DateOfEvent")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("Koala.DAL.Entities.EventPicture", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<int>("EventID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.HasKey("ID");

                    b.HasIndex("EventID");

                    b.ToTable("EventPicture");
                });

            modelBuilder.Entity("Koala.DAL.Entities.Gallery", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Gallery");
                });

            modelBuilder.Entity("Koala.DAL.Entities.GalleryPicture", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("GalleryID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.HasKey("ID");

                    b.HasIndex("GalleryID");

                    b.ToTable("GalleryPicture");
                });

            modelBuilder.Entity("Koala.DAL.Entities.Kitchen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Kitchen");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Kitchen");
                });

            modelBuilder.Entity("Koala.DAL.Entities.People", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.HasKey("ID");

                    b.ToTable("People");
                });

            modelBuilder.Entity("Koala.DAL.Entities.Slider", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<int>("DisplayIndex")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Slogan")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Slider");
                });

            modelBuilder.Entity("Koala.DAL.Entities.Drink", b =>
                {
                    b.HasBaseType("Koala.DAL.Entities.Kitchen");

                    b.HasDiscriminator().HasValue("Drink");
                });

            modelBuilder.Entity("Koala.DAL.Entities.Food", b =>
                {
                    b.HasBaseType("Koala.DAL.Entities.Kitchen");

                    b.HasDiscriminator().HasValue("Food");
                });

            modelBuilder.Entity("Koala.DAL.Entities.Cold", b =>
                {
                    b.HasBaseType("Koala.DAL.Entities.Drink");

                    b.HasDiscriminator().HasValue("Cold");
                });

            modelBuilder.Entity("Koala.DAL.Entities.Desert", b =>
                {
                    b.HasBaseType("Koala.DAL.Entities.Food");

                    b.HasDiscriminator().HasValue("Desert");
                });

            modelBuilder.Entity("Koala.DAL.Entities.Hot", b =>
                {
                    b.HasBaseType("Koala.DAL.Entities.Drink");

                    b.HasDiscriminator().HasValue("Hot");
                });

            modelBuilder.Entity("Koala.DAL.Entities.Snack", b =>
                {
                    b.HasBaseType("Koala.DAL.Entities.Food");

                    b.HasDiscriminator().HasValue("Snack");
                });

            modelBuilder.Entity("Koala.DAL.Entities.EventPicture", b =>
                {
                    b.HasOne("Koala.DAL.Entities.Event", "Event")
                        .WithMany("EventPictures")
                        .HasForeignKey("EventID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("Koala.DAL.Entities.GalleryPicture", b =>
                {
                    b.HasOne("Koala.DAL.Entities.Gallery", "Gallery")
                        .WithMany("GalleryPictures")
                        .HasForeignKey("GalleryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Gallery");
                });

            modelBuilder.Entity("Koala.DAL.Entities.Event", b =>
                {
                    b.Navigation("EventPictures");
                });

            modelBuilder.Entity("Koala.DAL.Entities.Gallery", b =>
                {
                    b.Navigation("GalleryPictures");
                });
#pragma warning restore 612, 618
        }
    }
}
