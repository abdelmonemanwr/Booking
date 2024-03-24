﻿// <auto-generated />
using System;
using Booking.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Booking.Migrations
{
    [DbContext(typeof(BookingContext))]
    [Migration("20240324233751_men3m-v1")]
    partial class men3mv1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.2.24128.4")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Booking.Models.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"));

                    b.Property<DateTime?>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CheckoutDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Days")
                        .HasColumnType("int");

                    b.Property<int>("NonHotelID")
                        .HasColumnType("int");

                    b.Property<int>("PaymentID")
                        .HasColumnType("int");

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("BookingID");

                    b.HasIndex("NonHotelID");

                    b.HasIndex("PaymentID");

                    b.HasIndex("RoomID");

                    b.HasIndex("UserID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Booking.Models.Dependent", b =>
                {
                    b.Property<int>("DeptID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeptID"));

                    b.Property<string>("DeptName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("DeptID");

                    b.HasIndex("UserID");

                    b.ToTable("Dependents");
                });

            modelBuilder.Entity("Booking.Models.Feedback", b =>
                {
                    b.Property<int>("FeedbackID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeedbackID"));

                    b.Property<string>("Feed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HotelID")
                        .HasColumnType("int");

                    b.Property<int?>("Rate")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("FeedbackID");

                    b.HasIndex("HotelID");

                    b.HasIndex("UserID");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("Booking.Models.Hotel", b =>
                {
                    b.Property<int>("HotelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.Property<int?>("RoomsNumber")
                        .HasColumnType("int");

                    b.HasKey("HotelID");

                    b.HasIndex("LocationID");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("Booking.Models.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationID"));

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Booking.Models.NonHotel", b =>
                {
                    b.Property<int>("NonHotelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NonHotelID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.Property<string>("NonHotelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Reserved")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NonHotelID");

                    b.HasIndex("LocationID");

                    b.ToTable("NonHotels");
                });

            modelBuilder.Entity("Booking.Models.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentID"));

                    b.Property<decimal?>("Amount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Booking.Models.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HotelID")
                        .HasColumnType("int");

                    b.Property<decimal?>("PriceForNight")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<bool?>("Reserved")
                        .HasColumnType("bit");

                    b.Property<int?>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<string>("RoomType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomID");

                    b.HasIndex("HotelID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Booking.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Booking.Models.Booking", b =>
                {
                    b.HasOne("Booking.Models.NonHotel", "NonHotel")
                        .WithMany("Bookings")
                        .HasForeignKey("NonHotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Booking.Models.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Booking.Models.Room", "Room")
                        .WithMany("Bookings")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Booking.Models.User", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NonHotel");

                    b.Navigation("Payment");

                    b.Navigation("Room");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Booking.Models.Dependent", b =>
                {
                    b.HasOne("Booking.Models.User", "User")
                        .WithMany("Dependents")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Booking.Models.Feedback", b =>
                {
                    b.HasOne("Booking.Models.Hotel", "Hotel")
                        .WithMany("Feedbacks")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Booking.Models.User", "User")
                        .WithMany("Feedbacks")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Booking.Models.Hotel", b =>
                {
                    b.HasOne("Booking.Models.Location", "Location")
                        .WithMany("Hotels")
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Booking.Models.NonHotel", b =>
                {
                    b.HasOne("Booking.Models.Location", "Location")
                        .WithMany("NonHotels")
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Booking.Models.Room", b =>
                {
                    b.HasOne("Booking.Models.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Booking.Models.Hotel", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("Booking.Models.Location", b =>
                {
                    b.Navigation("Hotels");

                    b.Navigation("NonHotels");
                });

            modelBuilder.Entity("Booking.Models.NonHotel", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("Booking.Models.Room", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("Booking.Models.User", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Dependents");

                    b.Navigation("Feedbacks");
                });
#pragma warning restore 612, 618
        }
    }
}