﻿// <auto-generated />
using System;
using DocuSQL.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DocuSQL.API.Migrations
{
    [DbContext(typeof(DocuSQLContext))]
    [Migration("20191103114237_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DocuSQL.API.Models.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SubmissionId")
                        .HasMaxLength(256);

                    b.Property<DateTime>("SubmissionTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.HasKey("Id");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("DocuSQL.API.Models.Field", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DocumentId");

                    b.Property<string>("FieldId")
                        .IsRequired();

                    b.Property<string>("FieldValue");

                    b.HasKey("Id");

                    b.HasIndex("DocumentId");

                    b.ToTable("Field");
                });

            modelBuilder.Entity("DocuSQL.API.Models.Field", b =>
                {
                    b.HasOne("DocuSQL.API.Models.Document", "Document")
                        .WithMany("Fields")
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
