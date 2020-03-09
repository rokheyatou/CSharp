﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NR.MyAirport.EF;

namespace MyAirport.EntityF.Migrations
{
    [DbContext(typeof(MyAirportContext))]
    partial class MyAirportContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NR.MyAirport.EF.Bagage", b =>
                {
                    b.Property<int>("BagageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Classe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodeIATA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Escale")
                        .HasColumnType("int");

                    b.Property<bool>("Priorite")
                        .HasColumnType("bit");

                    b.Property<int>("Ssur")
                        .HasColumnType("int");

                    b.Property<string>("Sta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VolId")
                        .HasColumnType("int");

                    b.HasKey("BagageId");

                    b.HasIndex("VolId");

                    b.ToTable("Bagages");
                });

            modelBuilder.Entity("NR.MyAirport.EF.Vol", b =>
                {
                    b.Property<int>("VolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Des")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dhc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Imm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lig")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pax")
                        .HasColumnType("int");

                    b.Property<string>("Pkg")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VolId");

                    b.ToTable("Vols");
                });

            modelBuilder.Entity("NR.MyAirport.EF.Bagage", b =>
                {
                    b.HasOne("NR.MyAirport.EF.Vol", "Vol")
                        .WithMany()
                        .HasForeignKey("VolId");
                });
#pragma warning restore 612, 618
        }
    }
}
