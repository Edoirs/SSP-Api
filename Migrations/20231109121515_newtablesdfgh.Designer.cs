﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SelfPortalAPi.NewTables;

#nullable disable

namespace SelfPortalAPi.Migrations
{
    [DbContext(typeof(PayeeContext))]
    [Migration("20231109121515_newtablesdfgh")]
    partial class newtablesdfgh
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SelfPortalAPi.NewTables.Business", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UniqueId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("business_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("business_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("business_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("created_at")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("employees_count")
                        .HasColumnType("int");

                    b.Property<string>("industry_sector_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("industry_subsector_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lga_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("link_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("taxpayer_role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("taxpayer_role_id")
                        .HasColumnType("int");

                    b.Property<string>("town_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ward_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Businesses");
                });

            modelBuilder.Entity("SelfPortalAPi.NewTables.Cooperate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UniqueId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("active_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cac_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("company_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("company_type_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("corporate_logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("created_by_app_id")
                        .HasColumnType("int");

                    b.Property<string>("economic_activity_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email_2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("has_valid_email")
                        .HasColumnType("int");

                    b.Property<int>("industry_sector_id")
                        .HasColumnType("int");

                    b.Property<string>("lga_code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("normalized_state_tin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("parent_taxpayer_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone_2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("reminder_annual_projection_sent_at")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("reminder_annual_return_sent_at")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("reminder_sent_at")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state_code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state_tin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<int>("tax_office_id")
                        .HasColumnType("int");

                    b.Property<string>("taxpayer_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Cooperates");
                });

            modelBuilder.Entity("SelfPortalAPi.NewTables.LocalGovernment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UniqueId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("active")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("lga_code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("LocalGovernments");
                });

            modelBuilder.Entity("SelfPortalAPi.NewTables.LocalGovtPostalCodes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UniqueId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("active")
                        .HasColumnType("int");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("created_at")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("postalcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("state_id")
                        .HasColumnType("int");

                    b.Property<string>("updated_at")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LocalGovtPostalCodees");
                });

            modelBuilder.Entity("SelfPortalAPi.NewTables.employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UniqueId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("asset_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("basic")
                        .HasColumnType("int");

                    b.Property<int>("business_id")
                        .HasColumnType("int");

                    b.Property<string>("bvn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("corporate_id")
                        .HasColumnType("int");

                    b.Property<string>("cra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("deleted_at")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gross_income")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("home_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lga_code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("life_assurance")
                        .HasColumnType("int");

                    b.Property<string>("nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nhf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nhis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("normalized_state_tin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("other_income")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("other_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rent")
                        .HasColumnType("int");

                    b.Property<string>("start_month")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state_code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state_tin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<string>("taxpayer_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("total_income")
                        .HasColumnType("int");

                    b.Property<int>("transport")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("zip_code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("employees");
                });
#pragma warning restore 612, 618
        }
    }
}
