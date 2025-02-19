﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06.Models;

namespace Mission06.Migrations
{
    [DbContext(typeof(MovieApplicationContext))]
    partial class MovieApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission06.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("applicationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<short>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("applicationID");

                    b.HasIndex("CategoryID");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            applicationID = 1,
                            CategoryID = 1,
                            Director = "John McTernan",
                            Edited = false,
                            Lent = "Cade Gardanier",
                            Notes = "Best Christmas Movie",
                            Rating = "PG-13",
                            Title = "Die Hard",
                            Year = (short)1988
                        },
                        new
                        {
                            applicationID = 2,
                            CategoryID = 2,
                            Director = "Boaz Yakin",
                            Edited = false,
                            Lent = "Cade Gardanier",
                            Notes = "Good film",
                            Rating = "PG",
                            Title = "Remember The Titans",
                            Year = (short)2000
                        },
                        new
                        {
                            applicationID = 3,
                            CategoryID = 3,
                            Director = "Steven Spielberg",
                            Edited = true,
                            Lent = "Cade Gardanier",
                            Notes = "might want it edited",
                            Rating = "R",
                            Title = "Saving Private Ryan",
                            Year = (short)1998
                        });
                });

            modelBuilder.Entity("Mission06.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Sports"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "War"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryID = 9,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryID = 10,
                            CategoryName = "VHS"
                        });
                });

            modelBuilder.Entity("Mission06.Models.ApplicationResponse", b =>
                {
                    b.HasOne("Mission06.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
