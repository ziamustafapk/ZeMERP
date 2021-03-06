﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZeMERP.Data;

namespace ZeMERP.Data.Migrations
{
    [DbContext(typeof(ZeMERPDbContext))]
    partial class ZeMERPDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ZeMERP.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId");

                    b.Property<int>("CountryId");

                    b.Property<int?>("EmployeeId");

                    b.Property<string>("StreetAddress")
                        .HasMaxLength(100);

                    b.HasKey("AddressId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("STP_ADDRESS");
                });

            modelBuilder.Entity("ZeMERP.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("DepartmentId");

                    b.ToTable("STP_DEPARTMENT");
                });

            modelBuilder.Entity("ZeMERP.Models.Email", b =>
                {
                    b.Property<int>("EmailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("EmployeeId");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("EmailId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("STP_EMAIL");
                });

            modelBuilder.Entity("ZeMERP.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime?>("CreatedDate")
                        .IsRequired();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<int>("DepartmentId");

                    b.Property<string>("Description")
                        .HasMaxLength(100);

                    b.Property<string>("FatherName")
                        .HasMaxLength(100);

                    b.Property<string>("FaxNo")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("MaritalStatus")
                        .HasMaxLength(50);

                    b.Property<string>("MiddleName")
                        .HasMaxLength(50);

                    b.Property<string>("Picture")
                        .HasMaxLength(200);

                    b.Property<string>("Remarks")
                        .HasMaxLength(200);

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("STP_EMPLOYEE");
                });

            modelBuilder.Entity("ZeMERP.Models.Phone", b =>
                {
                    b.Property<int>("PhoneNumberId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeeId");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Type")
                        .HasMaxLength(50);

                    b.HasKey("PhoneNumberId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("STP_PHONE");
                });

            modelBuilder.Entity("ZeMERP.Models.Address", b =>
                {
                    b.HasOne("ZeMERP.Models.Employee", "Employee")
                        .WithMany("Address")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("ZeMERP.Models.Email", b =>
                {
                    b.HasOne("ZeMERP.Models.Employee", "Employee")
                        .WithMany("Email")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("ZeMERP.Models.Employee", b =>
                {
                    b.HasOne("ZeMERP.Models.Department", "Department")
                        .WithMany("Employee")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ZeMERP.Models.Phone", b =>
                {
                    b.HasOne("ZeMERP.Models.Employee", "Employee")
                        .WithMany("Phone")
                        .HasForeignKey("EmployeeId");
                });
#pragma warning restore 612, 618
        }
    }
}
