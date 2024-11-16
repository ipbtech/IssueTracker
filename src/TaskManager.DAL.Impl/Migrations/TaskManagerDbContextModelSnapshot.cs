﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskManager.DAL.Impl;

#nullable disable

namespace TaskManager.DAL.Impl.Migrations
{
    [DbContext(typeof(TaskManagerDbContext))]
    partial class TaskManagerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.11");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TaskManager.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDateTimeUTC")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedDateTimeUTC")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "eb08f2a4-59ff-4205-9dc2-6815f39bc101",
                            CreatedDateTimeUTC = new DateTime(2024, 11, 16, 14, 6, 30, 304, DateTimeKind.Utc).AddTicks(7572),
                            DisplayName = "Matthew Auer",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "DOMINGO_UPTON73",
                            PasswordHash = "AQAAAAIAAYagAAAAEHXOWOJhHXJEQJaNmdDDlOEi5vaawS7KU875MvlWJjpTMVO0A37LAyCOD8ABC02kfA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e61f79da-6187-4485-bf9e-46dde7978bf1",
                            TwoFactorEnabled = false,
                            UpdatedDateTimeUTC = new DateTime(2024, 11, 16, 14, 6, 30, 304, DateTimeKind.Utc).AddTicks(7829),
                            UserName = "Domingo_Upton73"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "84712b13-2708-4b79-a2dd-81cd9a24718d",
                            CreatedDateTimeUTC = new DateTime(2024, 11, 16, 14, 6, 30, 304, DateTimeKind.Utc).AddTicks(9255),
                            DisplayName = "Kelly Dickens",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "LOUIS_DIETRICH",
                            PasswordHash = "AQAAAAIAAYagAAAAEMCROh+LNxV/vmw+W+ocPYvv85Y4e1JxE3NGQNCJlDf+OZ+Z5sCXsr/xsXvhWwoRSQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9c6ae5bb-5ac9-4938-9214-5e9f3d7d518c",
                            TwoFactorEnabled = false,
                            UpdatedDateTimeUTC = new DateTime(2024, 11, 16, 14, 6, 30, 304, DateTimeKind.Utc).AddTicks(9261),
                            UserName = "Louis_Dietrich"
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "aa006451-c006-4a5a-b686-0d92c85ae16f",
                            CreatedDateTimeUTC = new DateTime(2024, 11, 16, 14, 6, 30, 304, DateTimeKind.Utc).AddTicks(9615),
                            DisplayName = "Michael Weimann",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "ERIK_BLOCK25",
                            PasswordHash = "AQAAAAIAAYagAAAAEPvbrKZpdFcuwqADuWEDcxVFG/gZJxkfq2Myp2eBhiuKGgdIhKY8w8rQ0AZP+V9XAA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e5dd4f50-0772-446a-9100-f49dc5c3f9b9",
                            TwoFactorEnabled = false,
                            UpdatedDateTimeUTC = new DateTime(2024, 11, 16, 14, 6, 30, 304, DateTimeKind.Utc).AddTicks(9621),
                            UserName = "Erik_Block25"
                        },
                        new
                        {
                            Id = 4,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a5a7e2ef-5872-4902-9dbd-ed19e0143910",
                            CreatedDateTimeUTC = new DateTime(2024, 11, 16, 14, 6, 30, 304, DateTimeKind.Utc).AddTicks(9915),
                            DisplayName = "Oliver Pfannerstill",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "EUGENE.BAILEY75",
                            PasswordHash = "AQAAAAIAAYagAAAAENmkYLa2G9FHmLGiy6s5E5dLamrId39oC51B1v1CPsVne0RjjCxQWQiRUxoye1dKTQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "afcceae2-8254-49d1-848c-56b41444d3a6",
                            TwoFactorEnabled = false,
                            UpdatedDateTimeUTC = new DateTime(2024, 11, 16, 14, 6, 30, 304, DateTimeKind.Utc).AddTicks(9941),
                            UserName = "Eugene.Bailey75"
                        },
                        new
                        {
                            Id = 5,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2454eebb-f244-4d35-9a23-694e04752d88",
                            CreatedDateTimeUTC = new DateTime(2024, 11, 16, 14, 6, 30, 305, DateTimeKind.Utc).AddTicks(224),
                            DisplayName = "Nicolas Rosenbaum",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "SANTIAGO59",
                            PasswordHash = "AQAAAAIAAYagAAAAEAWY3DBsoE5x9Jg8NYQXpGuruaQrdKJW3EbfKS1347DUSH5qknetrJmRnghupzxUNg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cd22dee1-9d73-46eb-b343-295fdf11b8f9",
                            TwoFactorEnabled = false,
                            UpdatedDateTimeUTC = new DateTime(2024, 11, 16, 14, 6, 30, 305, DateTimeKind.Utc).AddTicks(228),
                            UserName = "Santiago59"
                        },
                        new
                        {
                            Id = 6,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9e733ed4-fbea-4801-9a6d-80304dbf1fc7",
                            CreatedDateTimeUTC = new DateTime(2024, 11, 16, 14, 6, 30, 305, DateTimeKind.Utc).AddTicks(829),
                            DisplayName = "Tony Jaskolski",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "GREGORY91",
                            PasswordHash = "AQAAAAIAAYagAAAAEKOd/9WNMzEhGdImg+LZ1XjGlSvZ96y0pCtnEbhF3HJZvawZz33MHuI2tDYTl2HfUw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "da4f0da4-8e86-4938-b8ee-6287c384c114",
                            TwoFactorEnabled = false,
                            UpdatedDateTimeUTC = new DateTime(2024, 11, 16, 14, 6, 30, 305, DateTimeKind.Utc).AddTicks(834),
                            UserName = "Gregory91"
                        },
                        new
                        {
                            Id = 7,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d88630b7-b2d2-427f-b5fa-e2d26d5e31b5",
                            CreatedDateTimeUTC = new DateTime(2024, 11, 16, 14, 6, 30, 305, DateTimeKind.Utc).AddTicks(1092),
                            DisplayName = "Guillermo Bruen",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "ISRAEL.WATERS19",
                            PasswordHash = "AQAAAAIAAYagAAAAEKqXJJIcFFSfjKT3yBRmdXvZrG9qy81+b+N6DJrdFhzCdckwX4lS6fqMWXUENuc+hQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e6eb00ef-0858-43f0-8ae3-604a0a036576",
                            TwoFactorEnabled = false,
                            UpdatedDateTimeUTC = new DateTime(2024, 11, 16, 14, 6, 30, 305, DateTimeKind.Utc).AddTicks(1097),
                            UserName = "Israel.Waters19"
                        });
                });

            modelBuilder.Entity("TaskManager.Entities.WorkTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ClosedDateTimeUTC")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDateTimeUTC")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan?>("FactedTimeSpan")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("PlannedDateTimeUTC")
                        .HasColumnType("TEXT");

                    b.Property<int>("StatusId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedDateTimeUTC")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("TaskManager.Entities.WorkTaskComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDateTimeUTC")
                        .HasColumnType("TEXT");

                    b.Property<int>("TaskId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedDateTimeUTC")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("TaskManager.Entities.WorkTaskStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDateTimeUTC")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDateTimeUTC")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDateTimeUTC = new DateTime(2024, 11, 16, 14, 6, 31, 358, DateTimeKind.Utc).AddTicks(282),
                            Name = "Создана",
                            UpdatedDateTimeUTC = new DateTime(2024, 11, 16, 14, 6, 31, 358, DateTimeKind.Utc).AddTicks(304)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDateTimeUTC = new DateTime(2024, 11, 16, 14, 6, 31, 358, DateTimeKind.Utc).AddTicks(345),
                            Name = "В работе",
                            UpdatedDateTimeUTC = new DateTime(2024, 11, 16, 14, 6, 31, 358, DateTimeKind.Utc).AddTicks(346)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDateTimeUTC = new DateTime(2024, 11, 16, 14, 6, 31, 358, DateTimeKind.Utc).AddTicks(350),
                            Name = "Пауза",
                            UpdatedDateTimeUTC = new DateTime(2024, 11, 16, 14, 6, 31, 358, DateTimeKind.Utc).AddTicks(350)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDateTimeUTC = new DateTime(2024, 11, 16, 14, 6, 31, 358, DateTimeKind.Utc).AddTicks(356),
                            Name = "Завершена",
                            UpdatedDateTimeUTC = new DateTime(2024, 11, 16, 14, 6, 31, 358, DateTimeKind.Utc).AddTicks(357)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("TaskManager.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("TaskManager.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManager.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("TaskManager.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TaskManager.Entities.WorkTask", b =>
                {
                    b.HasOne("TaskManager.Entities.WorkTaskStatus", "Status")
                        .WithMany("Tasks")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManager.Entities.User", "User")
                        .WithMany("Tasks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Status");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TaskManager.Entities.WorkTaskComment", b =>
                {
                    b.HasOne("TaskManager.Entities.WorkTask", "Task")
                        .WithMany("Comments")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManager.Entities.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TaskManager.Entities.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("TaskManager.Entities.WorkTask", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("TaskManager.Entities.WorkTaskStatus", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
