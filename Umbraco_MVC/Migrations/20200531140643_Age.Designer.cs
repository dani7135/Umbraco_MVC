﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Umbraco_MVC.Data;

namespace Umbraco_MVC.Migrations
{
    [DbContext(typeof(SubmissionContext))]
    [Migration("20200531140643_Age")]
    partial class Age
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Umbraco_MVC.Models.SerialNumber", b =>
                {
                    b.Property<int>("KeyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KeyCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfUses")
                        .HasColumnType("int");

                    b.Property<int?>("SubmissionId")
                        .HasColumnType("int");

                    b.Property<bool>("Validity")
                        .HasColumnType("bit");

                    b.HasKey("KeyId");

                    b.HasIndex("SubmissionId");

                    b.ToTable("SerialNumber");
                });

            modelBuilder.Entity("Umbraco_MVC.Models.Submission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Submissions");
                });

            modelBuilder.Entity("Umbraco_MVC.Models.SerialNumber", b =>
                {
                    b.HasOne("Umbraco_MVC.Models.Submission", "Submission")
                        .WithMany("SerialNumber")
                        .HasForeignKey("SubmissionId");
                });
#pragma warning restore 612, 618
        }
    }
}
