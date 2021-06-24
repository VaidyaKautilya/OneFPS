﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OneFPS.Data;

namespace OneFPS.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210624081433_ReportFileSetting")]
    partial class ReportFileSetting
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OneFPS.Entities.ReportFileSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AttechedFileType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsDatePrefix")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDateSuffix")
                        .HasColumnType("bit");

                    b.Property<int>("ScheduleReportId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ReportFileSettings");
                });

            modelBuilder.Entity("OneFPS.Entities.ScheduleReportManager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmailSettingId")
                        .HasColumnType("int");

                    b.Property<int>("EndPage")
                        .HasColumnType("int");

                    b.Property<string>("FileStoragePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParameterJson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReportFileSettingId")
                        .HasColumnType("int");

                    b.Property<int>("ReportFrequancyId")
                        .HasColumnType("int");

                    b.Property<string>("ReportName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StartPage")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransMissionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UseReportPageSize")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ScheduleReportManagers");
                });
#pragma warning restore 612, 618
        }
    }
}
