﻿// <auto-generated />
using Gear.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gear.Data.Migrations
{
    [DbContext(typeof(GearContext))]
    partial class GearContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gear.Models.Bevel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("B")
                        .HasColumnType("float");

                    b.Property<double>("Dae1")
                        .HasColumnType("float");

                    b.Property<double>("Dae2")
                        .HasColumnType("float");

                    b.Property<double>("De1")
                        .HasColumnType("float");

                    b.Property<double>("De2")
                        .HasColumnType("float");

                    b.Property<double>("Delta1")
                        .HasColumnType("float");

                    b.Property<double>("Delta2")
                        .HasColumnType("float");

                    b.Property<double>("Dm1")
                        .HasColumnType("float");

                    b.Property<double>("Dm2")
                        .HasColumnType("float");

                    b.Property<double>("Mm")
                        .HasColumnType("float");

                    b.Property<double>("Mt")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Re")
                        .HasColumnType("float");

                    b.Property<double>("Rm")
                        .HasColumnType("float");

                    b.Property<int>("Z1")
                        .HasColumnType("int");

                    b.Property<int>("Z2")
                        .HasColumnType("int");

                    b.Property<double>("Zc")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Bevel");
                });

            modelBuilder.Entity("Gear.Models.Spur", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Aw")
                        .HasColumnType("float");

                    b.Property<double>("B1")
                        .HasColumnType("float");

                    b.Property<double>("B2")
                        .HasColumnType("float");

                    b.Property<double>("Betta")
                        .HasColumnType("float");

                    b.Property<double>("D1")
                        .HasColumnType("float");

                    b.Property<double>("D2")
                        .HasColumnType("float");

                    b.Property<double>("Da1")
                        .HasColumnType("float");

                    b.Property<double>("Da2")
                        .HasColumnType("float");

                    b.Property<double>("Df1")
                        .HasColumnType("float");

                    b.Property<double>("Df2")
                        .HasColumnType("float");

                    b.Property<double>("Hc")
                        .HasColumnType("float");

                    b.Property<double>("Mn")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Sc")
                        .HasColumnType("float");

                    b.Property<int>("Z1")
                        .HasColumnType("int");

                    b.Property<int>("Z2")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Spur");
                });

            modelBuilder.Entity("Gear.Models.Worm", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Aw")
                        .HasColumnType("float");

                    b.Property<double>("B1")
                        .HasColumnType("float");

                    b.Property<double>("B2")
                        .HasColumnType("float");

                    b.Property<double>("D1")
                        .HasColumnType("float");

                    b.Property<double>("D2")
                        .HasColumnType("float");

                    b.Property<double>("Da1")
                        .HasColumnType("float");

                    b.Property<double>("Da2")
                        .HasColumnType("float");

                    b.Property<double>("Dam2")
                        .HasColumnType("float");

                    b.Property<double>("Gamma")
                        .HasColumnType("float");

                    b.Property<double>("M")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Q")
                        .HasColumnType("float");

                    b.Property<string>("WormName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Z1")
                        .HasColumnType("int");

                    b.Property<int>("Z2")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Worm");
                });
#pragma warning restore 612, 618
        }
    }
}