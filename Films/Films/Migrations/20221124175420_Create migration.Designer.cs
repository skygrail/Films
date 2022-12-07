﻿// <auto-generated />
using System;
using Films.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Films.Migrations
{
    [DbContext(typeof(FilmsDbContext))]
    [Migration("20221124175420_Create migration")]
    partial class Createmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Films.Models.Categoryies", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categoryies");
                });

            modelBuilder.Entity("Films.Models.Chats", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("ID");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("Films.Models.Comments", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DateOfCreation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FilmID")
                        .HasColumnType("int");

                    b.Property<string>("TextOfComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("FilmID");

                    b.HasIndex("UserID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Films.Models.Companies", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Films.Models.Contries", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Contries");
                });

            modelBuilder.Entity("Films.Models.Facts", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FilmID")
                        .HasColumnType("int");

                    b.Property<string>("TextOfFact")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("FilmID");

                    b.ToTable("Facts");
                });

            modelBuilder.Entity("Films.Models.Film", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<int?>("CompanyID")
                        .HasColumnType("int");

                    b.Property<int?>("CountryReleaseID")
                        .HasColumnType("int");

                    b.Property<string>("DateRelease")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilmName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("CompanyID");

                    b.HasIndex("CountryReleaseID");

                    b.ToTable("Film");
                });

            modelBuilder.Entity("Films.Models.Messages", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ChatID")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ChatID");

                    b.HasIndex("UserID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Films.Models.Party", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ChatID")
                        .HasColumnType("int");

                    b.Property<string>("DateOfCreation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FilmID")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ChatID");

                    b.HasIndex("FilmID");

                    b.HasIndex("UserID");

                    b.ToTable("Party");
                });

            modelBuilder.Entity("Films.Models.Users", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Admin")
                        .HasColumnType("int");

                    b.Property<string>("BirthDay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Films.Models.UsersFilms", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FilmID")
                        .HasColumnType("int");

                    b.Property<string>("NameOfList")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("FilmID");

                    b.HasIndex("UserID");

                    b.ToTable("UsersFilms");
                });

            modelBuilder.Entity("Films.Models.UsersLogins", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("UsersLogins");
                });

            modelBuilder.Entity("Films.Models.Comments", b =>
                {
                    b.HasOne("Films.Models.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmID");

                    b.HasOne("Films.Models.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("Films.Models.Facts", b =>
                {
                    b.HasOne("Films.Models.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmID");
                });

            modelBuilder.Entity("Films.Models.Film", b =>
                {
                    b.HasOne("Films.Models.Categoryies", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID");

                    b.HasOne("Films.Models.Companies", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID");

                    b.HasOne("Films.Models.Contries", "CountryRelease")
                        .WithMany()
                        .HasForeignKey("CountryReleaseID");
                });

            modelBuilder.Entity("Films.Models.Messages", b =>
                {
                    b.HasOne("Films.Models.Chats", "Chat")
                        .WithMany()
                        .HasForeignKey("ChatID");

                    b.HasOne("Films.Models.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("Films.Models.Party", b =>
                {
                    b.HasOne("Films.Models.Chats", "Chat")
                        .WithMany()
                        .HasForeignKey("ChatID");

                    b.HasOne("Films.Models.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmID");

                    b.HasOne("Films.Models.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("Films.Models.UsersFilms", b =>
                {
                    b.HasOne("Films.Models.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmID");

                    b.HasOne("Films.Models.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("Films.Models.UsersLogins", b =>
                {
                    b.HasOne("Films.Models.Users", "User")
                        .WithOne("UsersLogins")
                        .HasForeignKey("Films.Models.UsersLogins", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
