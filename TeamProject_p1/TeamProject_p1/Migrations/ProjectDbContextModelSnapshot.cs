﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeamProject_p1.Data;

namespace TeamProject_p1.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    partial class ProjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TeamProject_p1.Models.Calender", b =>
                {
                    b.Property<int>("CalenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("TaskDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CalenderId");

                    b.ToTable("TaskDates");
                });

            modelBuilder.Entity("TeamProject_p1.Models.DailyTask", b =>
                {
                    b.Property<int>("DailyTaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DateId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DailyTaskId");

                    b.ToTable("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
