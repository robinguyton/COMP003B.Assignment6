﻿using COMP003B.Assignment6.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace COMP003B.Assignment6.Migrations
{
    [DbContext(typeof(WebDevAcademyContext))]
    partial class WebDevAcademyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("COMP003B.Assignment6.Models.Actors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("DirectorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Oscars")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.HasIndex("DirectorId");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("COMP003B.Assignment6.Models.Directors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DirectorID")
                        .HasColumnType("int");

                    b.Property<int?>("DirectorsId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DirectorsId");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("COMP003B.Assignment6.Models.Movies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ActorsId")
                        .HasColumnType("int");

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.Property<int?>("MoviesId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ActorsId");

                    b.HasIndex("MoviesId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("COMP003B.Assignment6.Models.Actors", b =>
                {
                    b.HasOne("COMP003B.Assignment6.Models.Actors", "Actor")
                        .WithMany()
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("COMP003B.Assignment6.Models.Directors", "Director")
                        .WithMany()
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actors");

                    b.Navigation("Directors");
                });

            modelBuilder.Entity("COMP003B.Assignment6.Models.Directors", b =>
                {
                    b.HasOne("COMP003B.Assignment6.Models.Directors", null)
                        .WithMany("Director")
                        .HasForeignKey("DirectorsId");
                });

            modelBuilder.Entity("COMP003B.Assignment6.Models.Movies", b =>
                {
                    b.HasOne("COMP003B.Assignment6.Models.Actors", null)
                        .WithMany("Movies")
                        .HasForeignKey("ActorsId");

                    b.HasOne("COMP003B.Assignment6.Models.Movies", null)
                        .WithMany("Movie")
                        .HasForeignKey("MoviesId");
                });

            modelBuilder.Entity("COMP003B.Assignment6.Models.Actors", b =>
                {
                    b.Navigation("Actors");
                });

            modelBuilder.Entity("COMP003B.Assignment6.Models.Directors", b =>
                {
                    b.Navigation("Directors");
                });

            modelBuilder.Entity("COMP003B.Assignment6.Models.Movies", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
