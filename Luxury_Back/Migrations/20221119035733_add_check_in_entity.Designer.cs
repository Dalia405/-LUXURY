﻿// <auto-generated />
using System;
using Luxury_Back.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Luxury_Back.Migrations
{
    [DbContext(typeof(LuxuryDb))]
    [Migration("20221119035733_add_check_in_entity")]
    partial class add_check_in_entity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IAttributeIBooking", b =>
                {
                    b.Property<int>("iAttributesId")
                        .HasColumnType("int");

                    b.Property<int>("iBookingsId")
                        .HasColumnType("int");

                    b.HasKey("iAttributesId", "iBookingsId");

                    b.HasIndex("iBookingsId");

                    b.ToTable("IAttributeIBooking");
                });

            modelBuilder.Entity("Luxury_Back.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("GovernorateId")
                        .HasColumnType("int");

                    b.Property<int?>("IBookingId")
                        .HasColumnType("int");

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("lat")
                        .HasColumnType("float");

                    b.Property<double?>("lng")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("GovernorateId");

                    b.HasIndex("IBookingId")
                        .IsUnique()
                        .HasFilter("[IBookingId] IS NOT NULL");

                    b.ToTable("addresses");
                });

            modelBuilder.Entity("Luxury_Back.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name_ar")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name_en")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("name_ar")
                        .IsUnique()
                        .HasFilter("[name_ar] IS NOT NULL");

                    b.HasIndex("name_en")
                        .IsUnique()
                        .HasFilter("[name_en] IS NOT NULL");

                    b.ToTable("brands", (string)null);
                });

            modelBuilder.Entity("Luxury_Back.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("img_category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name_ar")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name_en")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("name_ar")
                        .IsUnique();

                    b.HasIndex("name_en")
                        .IsUnique();

                    b.ToTable("categories");
                });

            modelBuilder.Entity("Luxury_Back.Models.Checked_In", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IBookingId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("checked_in")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("checked_out")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("created_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("nights_count")
                        .HasColumnType("int");

                    b.Property<DateTime?>("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IBookingId");

                    b.HasIndex("UserId");

                    b.ToTable("checked_in");
                });

            modelBuilder.Entity("Luxury_Back.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("gov_id")
                        .HasColumnType("int");

                    b.Property<string>("name_ar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name_en")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("gov_id");

                    b.ToTable("cities", (string)null);
                });

            modelBuilder.Entity("Luxury_Back.Models.Code_ForgetPass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("code_forget_passes");
                });

            modelBuilder.Entity("Luxury_Back.Models.Governorate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("img_governorate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name_ar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name_en")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("governorates", (string)null);
                });

            modelBuilder.Entity("Luxury_Back.Models.IAttribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("created_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("inputType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name_ar")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name_en")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("name_ar")
                        .IsUnique()
                        .HasFilter("[name_ar] IS NOT NULL");

                    b.HasIndex("name_en")
                        .IsUnique()
                        .HasFilter("[name_en] IS NOT NULL");

                    b.ToTable("iAttributes", (string)null);
                });

            modelBuilder.Entity("Luxury_Back.Models.IBooking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("Category_Id")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("created_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("description_ar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description_en")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name_ar")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name_en")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("Category_Id");

                    b.HasIndex("name_ar")
                        .IsUnique()
                        .HasFilter("[name_ar] IS NOT NULL");

                    b.HasIndex("name_en")
                        .IsUnique()
                        .HasFilter("[name_en] IS NOT NULL");

                    b.ToTable("iBookings", (string)null);
                });

            modelBuilder.Entity("Luxury_Back.Models.IBookingAttribute", b =>
                {
                    b.Property<int?>("IBookingId")
                        .HasColumnType("int");

                    b.Property<int?>("IAttributeId")
                        .HasColumnType("int");

                    b.Property<string>("value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IBookingId", "IAttributeId");

                    b.HasIndex("IAttributeId");

                    b.ToTable("iBookingAttributes", (string)null);
                });

            modelBuilder.Entity("Luxury_Back.Models.IBookingImg", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IBookingId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IBookingId");

                    b.ToTable("iBookingImg");
                });

            modelBuilder.Entity("Luxury_Back.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("IsEmailVerify")
                        .HasColumnType("bit");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<bool>("is_active")
                        .HasColumnType("bit");

                    b.Property<bool>("is_admin")
                        .HasColumnType("bit");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("updated_at")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("username")
                        .IsUnique();

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("IAttributeIBooking", b =>
                {
                    b.HasOne("Luxury_Back.Models.IAttribute", null)
                        .WithMany()
                        .HasForeignKey("iAttributesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Luxury_Back.Models.IBooking", null)
                        .WithMany()
                        .HasForeignKey("iBookingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Luxury_Back.Models.Address", b =>
                {
                    b.HasOne("Luxury_Back.Models.City", "City")
                        .WithMany("Addresses")
                        .HasForeignKey("CityId");

                    b.HasOne("Luxury_Back.Models.Governorate", "Governorate")
                        .WithMany("Addresses")
                        .HasForeignKey("GovernorateId");

                    b.HasOne("Luxury_Back.Models.IBooking", "IBooking")
                        .WithOne("Address")
                        .HasForeignKey("Luxury_Back.Models.Address", "IBookingId");

                    b.Navigation("City");

                    b.Navigation("Governorate");

                    b.Navigation("IBooking");
                });

            modelBuilder.Entity("Luxury_Back.Models.Brand", b =>
                {
                    b.HasOne("Luxury_Back.Models.Category", "category")
                        .WithMany("brands")
                        .HasForeignKey("CategoryId");

                    b.Navigation("category");
                });

            modelBuilder.Entity("Luxury_Back.Models.Category", b =>
                {
                    b.HasOne("Luxury_Back.Models.Category", "parent")
                        .WithMany("childs")
                        .HasForeignKey("CategoryId");

                    b.Navigation("parent");
                });

            modelBuilder.Entity("Luxury_Back.Models.Checked_In", b =>
                {
                    b.HasOne("Luxury_Back.Models.IBooking", "IBooking")
                        .WithMany("Checked_In")
                        .HasForeignKey("IBookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Luxury_Back.Models.User", "User")
                        .WithMany("Checked_In")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IBooking");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Luxury_Back.Models.City", b =>
                {
                    b.HasOne("Luxury_Back.Models.Governorate", "Governorate")
                        .WithMany("Cities")
                        .HasForeignKey("gov_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Governorate");
                });

            modelBuilder.Entity("Luxury_Back.Models.Code_ForgetPass", b =>
                {
                    b.HasOne("Luxury_Back.Models.User", "user")
                        .WithOne("code")
                        .HasForeignKey("Luxury_Back.Models.Code_ForgetPass", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("Luxury_Back.Models.IBooking", b =>
                {
                    b.HasOne("Luxury_Back.Models.Brand", "Brand")
                        .WithMany("iBookings")
                        .HasForeignKey("BrandId");

                    b.HasOne("Luxury_Back.Models.Category", "Category")
                        .WithMany("iBookings")
                        .HasForeignKey("Category_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Luxury_Back.Models.IBookingAttribute", b =>
                {
                    b.HasOne("Luxury_Back.Models.IAttribute", "IAttribute")
                        .WithMany("iBookingAttributes")
                        .HasForeignKey("IAttributeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Luxury_Back.Models.IBooking", "IBooking")
                        .WithMany("iBookingAttributes")
                        .HasForeignKey("IBookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IAttribute");

                    b.Navigation("IBooking");
                });

            modelBuilder.Entity("Luxury_Back.Models.IBookingImg", b =>
                {
                    b.HasOne("Luxury_Back.Models.IBooking", "booking")
                        .WithMany("images")
                        .HasForeignKey("IBookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("booking");
                });

            modelBuilder.Entity("Luxury_Back.Models.Brand", b =>
                {
                    b.Navigation("iBookings");
                });

            modelBuilder.Entity("Luxury_Back.Models.Category", b =>
                {
                    b.Navigation("brands");

                    b.Navigation("childs");

                    b.Navigation("iBookings");
                });

            modelBuilder.Entity("Luxury_Back.Models.City", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("Luxury_Back.Models.Governorate", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Cities");
                });

            modelBuilder.Entity("Luxury_Back.Models.IAttribute", b =>
                {
                    b.Navigation("iBookingAttributes");
                });

            modelBuilder.Entity("Luxury_Back.Models.IBooking", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("Checked_In");

                    b.Navigation("iBookingAttributes");

                    b.Navigation("images");
                });

            modelBuilder.Entity("Luxury_Back.Models.User", b =>
                {
                    b.Navigation("Checked_In");

                    b.Navigation("code");
                });
#pragma warning restore 612, 618
        }
    }
}
