﻿// <auto-generated />
using System;
using BloodTypeWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BloodTypeWeb.Migrations
{
    [DbContext(typeof(BloodTypeDbContext))]
    [Migration("20240327174104_AddBloodTypesCombinations")]
    partial class AddBloodTypesCombinations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.2.24128.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BloodTypeWeb.Areas.Identity.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("PregnancyTerm")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("BloodTypeWeb.Models.BloodType", b =>
                {
                    b.Property<string>("BloodTypeID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BloodTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BloodTypeID");

                    b.ToTable("BloodTypes");
                });

            modelBuilder.Entity("BloodTypeWeb.Models.ChildOutcomeRh", b =>
                {
                    b.Property<int>("OutcomeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OutcomeID"));

                    b.Property<string>("ChildBloodTypeID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ChildRhFactorID")
                        .HasColumnType("int");

                    b.Property<int>("CombinationID")
                        .HasColumnType("int");

                    b.Property<string>("Probability")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OutcomeID");

                    b.HasIndex("ChildBloodTypeID");

                    b.HasIndex("ChildRhFactorID");

                    b.HasIndex("CombinationID");

                    b.ToTable("ChildOutcomesRh");
                });

            modelBuilder.Entity("BloodTypeWeb.Models.ParentCombinationRh", b =>
                {
                    b.Property<int>("CombinationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CombinationID"));

                    b.Property<string>("FatherBloodTypeID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("FatherRhFactorID")
                        .HasColumnType("int");

                    b.Property<string>("MotherBloodTypeID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MotherRhFactorID")
                        .HasColumnType("int");

                    b.HasKey("CombinationID");

                    b.HasIndex("FatherBloodTypeID");

                    b.HasIndex("FatherRhFactorID");

                    b.HasIndex("MotherBloodTypeID");

                    b.HasIndex("MotherRhFactorID");

                    b.ToTable("ParentCombinationsRh");
                });

            modelBuilder.Entity("BloodTypeWeb.Models.RhFactor", b =>
                {
                    b.Property<int>("RhFactorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RhFactorID"));

                    b.Property<string>("RhFactorType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RhFactorID");

                    b.ToTable("RhFactors");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BloodTypeWeb.Models.ChildOutcomeRh", b =>
                {
                    b.HasOne("BloodTypeWeb.Models.BloodType", "ChildBloodType")
                        .WithMany("ChildOutcomes")
                        .HasForeignKey("ChildBloodTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BloodTypeWeb.Models.RhFactor", "ChildRhFactor")
                        .WithMany("ChildOutcomes")
                        .HasForeignKey("ChildRhFactorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BloodTypeWeb.Models.ParentCombinationRh", "ParentCombination")
                        .WithMany("ChildOutcomes")
                        .HasForeignKey("CombinationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChildBloodType");

                    b.Navigation("ChildRhFactor");

                    b.Navigation("ParentCombination");
                });

            modelBuilder.Entity("BloodTypeWeb.Models.ParentCombinationRh", b =>
                {
                    b.HasOne("BloodTypeWeb.Models.BloodType", "FatherBloodType")
                        .WithMany("FatherCombinations")
                        .HasForeignKey("FatherBloodTypeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BloodTypeWeb.Models.RhFactor", "FatherRhFactor")
                        .WithMany("FatherCombinations")
                        .HasForeignKey("FatherRhFactorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BloodTypeWeb.Models.BloodType", "MotherBloodType")
                        .WithMany("MotherCombinations")
                        .HasForeignKey("MotherBloodTypeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BloodTypeWeb.Models.RhFactor", "MotherRhFactor")
                        .WithMany("MotherCombinations")
                        .HasForeignKey("MotherRhFactorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("FatherBloodType");

                    b.Navigation("FatherRhFactor");

                    b.Navigation("MotherBloodType");

                    b.Navigation("MotherRhFactor");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BloodTypeWeb.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BloodTypeWeb.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BloodTypeWeb.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BloodTypeWeb.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BloodTypeWeb.Models.BloodType", b =>
                {
                    b.Navigation("ChildOutcomes");

                    b.Navigation("FatherCombinations");

                    b.Navigation("MotherCombinations");
                });

            modelBuilder.Entity("BloodTypeWeb.Models.ParentCombinationRh", b =>
                {
                    b.Navigation("ChildOutcomes");
                });

            modelBuilder.Entity("BloodTypeWeb.Models.RhFactor", b =>
                {
                    b.Navigation("ChildOutcomes");

                    b.Navigation("FatherCombinations");

                    b.Navigation("MotherCombinations");
                });
#pragma warning restore 612, 618
        }
    }
}