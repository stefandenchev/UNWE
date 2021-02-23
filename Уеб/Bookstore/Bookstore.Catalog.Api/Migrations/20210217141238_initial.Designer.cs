﻿// <auto-generated />
using System;
using Bookstore.Catalog.Api.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bookstore.Catalog.Api.Migrations
{
    [DbContext(typeof(CatalogDbContext))]
    [Migration("20210217141238_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bookstore.Catalog.Api.Entities.Author", b =>
                {
                    b.Property<int>("AuthorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BirthYear")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("AuthorID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Bookstore.Catalog.Api.Entities.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Cover")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("LanguageID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("PublisherID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("BookID");

                    b.HasIndex("ISBN")
                        .IsUnique()
                        .HasFilter("[ISBN] IS NOT NULL");

                    b.HasIndex("LanguageID");

                    b.HasIndex("PublisherID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Bookstore.Catalog.Api.Entities.BookAuthor", b =>
                {
                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int>("AuthorID")
                        .HasColumnType("int");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.HasKey("BookID", "AuthorID");

                    b.HasIndex("AuthorID");

                    b.ToTable("BookAuthor");
                });

            modelBuilder.Entity("Bookstore.Catalog.Api.Entities.BookGenre", b =>
                {
                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int>("GenreID")
                        .HasColumnType("int");

                    b.HasKey("BookID", "GenreID");

                    b.HasIndex("GenreID");

                    b.ToTable("BookGenre");
                });

            modelBuilder.Entity("Bookstore.Catalog.Api.Entities.Genre", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("GenreID");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Bookstore.Catalog.Api.Entities.Language", b =>
                {
                    b.Property<int>("LanguageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("LanguageID");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Bookstore.Catalog.Api.Entities.Publisher", b =>
                {
                    b.Property<int>("PublisherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PublisherID");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("Bookstore.Catalog.Api.Entities.Book", b =>
                {
                    b.HasOne("Bookstore.Catalog.Api.Entities.Language", "Language")
                        .WithMany("Books")
                        .HasForeignKey("LanguageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookstore.Catalog.Api.Entities.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bookstore.Catalog.Api.Entities.BookAuthor", b =>
                {
                    b.HasOne("Bookstore.Catalog.Api.Entities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookstore.Catalog.Api.Entities.Book", "Book")
                        .WithMany("Authors")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bookstore.Catalog.Api.Entities.BookGenre", b =>
                {
                    b.HasOne("Bookstore.Catalog.Api.Entities.Book", "Book")
                        .WithMany("Genres")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookstore.Catalog.Api.Entities.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
