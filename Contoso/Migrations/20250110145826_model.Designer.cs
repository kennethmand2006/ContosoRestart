﻿// <auto-generated />
using System;
using Contoso.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Contoso.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20250110145826_model")]
    partial class model
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Contoso.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseID"));

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<int?>("EnrollmentID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseID");

                    b.HasIndex("EnrollmentID");

                    b.ToTable("Course", (string)null);
                });

            modelBuilder.Entity("Contoso.Models.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnrollmentID"));

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("EnrollmentID");

                    b.HasIndex("CourseID");

                    b.ToTable("Enrollment", (string)null);
                });

            modelBuilder.Entity("Contoso.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Secret")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Student", (string)null);
                });

            modelBuilder.Entity("EnrollmentStudent", b =>
                {
                    b.Property<int>("EnrollmentsEnrollmentID")
                        .HasColumnType("int");

                    b.Property<int>("StudentsID")
                        .HasColumnType("int");

                    b.HasKey("EnrollmentsEnrollmentID", "StudentsID");

                    b.HasIndex("StudentsID");

                    b.ToTable("EnrollmentStudent");
                });

            modelBuilder.Entity("Contoso.Models.Course", b =>
                {
                    b.HasOne("Contoso.Models.Enrollment", null)
                        .WithMany("Courses")
                        .HasForeignKey("EnrollmentID");
                });

            modelBuilder.Entity("Contoso.Models.Enrollment", b =>
                {
                    b.HasOne("Contoso.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("EnrollmentStudent", b =>
                {
                    b.HasOne("Contoso.Models.Enrollment", null)
                        .WithMany()
                        .HasForeignKey("EnrollmentsEnrollmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Contoso.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Contoso.Models.Enrollment", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
