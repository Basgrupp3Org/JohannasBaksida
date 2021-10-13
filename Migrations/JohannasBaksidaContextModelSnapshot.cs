﻿// <auto-generated />
using System;
using JohannasBaksida.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JohannasBaksida.Migrations
{
    [DbContext(typeof(JohannasBaksidaContext))]
    partial class JohannasBaksidaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JohannasBaksida.Areas.Identity.Data.Entities.Balance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Sum")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Balance");
                });

            modelBuilder.Entity("JohannasBaksida.Areas.Identity.Data.Entities.BalanceChanged", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BalanceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("NewSum")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OldSum")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("BalanceId");

                    b.HasIndex("UserId");

                    b.ToTable("BalanceChanged");
                });

            modelBuilder.Entity("JohannasBaksida.Areas.Identity.Data.Entities.Budget", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Housing")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Income")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Unbudgeted")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Vehicle")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Budget");
                });

            modelBuilder.Entity("JohannasBaksida.Areas.Identity.Data.Entities.BudgetCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BudgetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FixedCostsCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid?>("VariableCostsCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BudgetId");

                    b.HasIndex("FixedCostsCategoryId");

                    b.HasIndex("UserId");

                    b.HasIndex("VariableCostsCategoryId");

                    b.ToTable("BudgetCategory");
                });

            modelBuilder.Entity("JohannasBaksida.Areas.Identity.Data.Entities.FixedCostsCategories", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Sum")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("FixedCostsCategories");
                });

            modelBuilder.Entity("JohannasBaksida.Areas.Identity.Data.Entities.Purchase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("JohannasBaksidaUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("VariableCostsCategoriesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("JohannasBaksidaUserId");

                    b.HasIndex("VariableCostsCategoriesId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("JohannasBaksida.Areas.Identity.Data.Entities.SavingGoal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Saved")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ToSave")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("SavingGoal");
                });

            modelBuilder.Entity("JohannasBaksida.Areas.Identity.Data.Entities.VariableCostsCategories", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BudgetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Spent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ToSpend")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("BudgetId");

                    b.HasIndex("UserId");

                    b.ToTable("VariableCostsCategories");
                });

            modelBuilder.Entity("JohannasBaksida.Areas.Identity.Data.JohannasBaksidaUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<decimal>("BalanceUser")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.ToTable("AspNetUsers");
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

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("JohannasBaksida.Areas.Identity.Data.Entities.Balance", b =>
                {
                    b.HasOne("JohannasBaksida.Areas.Identity.Data.JohannasBaksidaUser", "User")
                        .WithMany("Balance")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JohannasBaksida.Areas.Identity.Data.Entities.BalanceChanged", b =>
                {
                    b.HasOne("JohannasBaksida.Areas.Identity.Data.Entities.Balance", "Balance")
                        .WithMany("BalanceChanges")
                        .HasForeignKey("BalanceId");

                    b.HasOne("JohannasBaksida.Areas.Identity.Data.JohannasBaksidaUser", "User")
                        .WithMany("BalanceChanges")
                        .HasForeignKey("UserId");

                    b.Navigation("Balance");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JohannasBaksida.Areas.Identity.Data.Entities.Budget", b =>
                {
                    b.HasOne("JohannasBaksida.Areas.Identity.Data.JohannasBaksidaUser", "User")
                        .WithMany("Budgets")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JohannasBaksida.Areas.Identity.Data.Entities.BudgetCategory", b =>
                {
                    b.HasOne("JohannasBaksida.Areas.Identity.Data.Entities.Budget", "Budget")
                        .WithMany("BudgetCategory")
                        .HasForeignKey("BudgetId");

                    b.HasOne("JohannasBaksida.Areas.Identity.Data.Entities.FixedCostsCategories", "FixedCostsCategory")
                        .WithMany("BudgetCategory")
                        .HasForeignKey("FixedCostsCategoryId");

                    b.HasOne("JohannasBaksida.Areas.Identity.Data.JohannasBaksidaUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("JohannasBaksida.Areas.Identity.Data.Entities.VariableCostsCategories", "VariableCostsCategory")
                        .WithMany("BudgetCategories")
                        .HasForeignKey("VariableCostsCategoryId");

                    b.Navigation("Budget");

                    b.Navigation("FixedCostsCategory");

                    b.Navigation("User");

                    b.Navigation("VariableCostsCategory");
                });

            modelBuilder.Entity("JohannasBaksida.Areas.Identity.Data.Entities.FixedCostsCategories", b =>
                {
                    b.HasOne("JohannasBaksida.Areas.Identity.Data.JohannasBaksidaUser", "User")
                        .WithMany("FixedCostsCategories")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JohannasBaksida.Areas.Identity.Data.Entities.Purchase", b =>
                {
                    b.HasOne("JohannasBaksida.Areas.Identity.Data.JohannasBaksidaUser", null)
                        .WithMany("Purchases")
                        .HasForeignKey("JohannasBaksidaUserId");

                    b.HasOne("JohannasBaksida.Areas.Identity.Data.Entities.VariableCostsCategories", null)
                        .WithMany("Purchases")
                        .HasForeignKey("VariableCostsCategoriesId");
                });

            modelBuilder.Entity("JohannasBaksida.Areas.Identity.Data.Entities.SavingGoal", b =>
                {
                    b.HasOne("JohannasBaksida.Areas.Identity.Data.JohannasBaksidaUser", "User")
                        .WithMany("SavingGoals")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JohannasBaksida.Areas.Identity.Data.Entities.VariableCostsCategories", b =>
                {
                    b.HasOne("JohannasBaksida.Areas.Identity.Data.Entities.Budget", "Budget")
                        .WithMany()
                        .HasForeignKey("BudgetId");

                    b.HasOne("JohannasBaksida.Areas.Identity.Data.JohannasBaksidaUser", "User")
                        .WithMany("VariableCostsCategories")
                        .HasForeignKey("UserId");

                    b.Navigation("Budget");

                    b.Navigation("User");
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
                    b.HasOne("JohannasBaksida.Areas.Identity.Data.JohannasBaksidaUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("JohannasBaksida.Areas.Identity.Data.JohannasBaksidaUser", null)
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

                    b.HasOne("JohannasBaksida.Areas.Identity.Data.JohannasBaksidaUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("JohannasBaksida.Areas.Identity.Data.JohannasBaksidaUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JohannasBaksida.Areas.Identity.Data.Entities.Balance", b =>
                {
                    b.Navigation("BalanceChanges");
                });

            modelBuilder.Entity("JohannasBaksida.Areas.Identity.Data.Entities.Budget", b =>
                {
                    b.Navigation("BudgetCategory");
                });

            modelBuilder.Entity("JohannasBaksida.Areas.Identity.Data.Entities.FixedCostsCategories", b =>
                {
                    b.Navigation("BudgetCategory");
                });

            modelBuilder.Entity("JohannasBaksida.Areas.Identity.Data.Entities.VariableCostsCategories", b =>
                {
                    b.Navigation("BudgetCategories");

                    b.Navigation("Purchases");
                });

            modelBuilder.Entity("JohannasBaksida.Areas.Identity.Data.JohannasBaksidaUser", b =>
                {
                    b.Navigation("Balance");

                    b.Navigation("BalanceChanges");

                    b.Navigation("Budgets");

                    b.Navigation("FixedCostsCategories");

                    b.Navigation("Purchases");

                    b.Navigation("SavingGoals");

                    b.Navigation("VariableCostsCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
