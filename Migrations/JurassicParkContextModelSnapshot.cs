﻿// <auto-generated />
using JurassicPark.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace jurassicpark.Migrations
{
    [DbContext(typeof(JurassicParkContext))]
    partial class JurassicParkContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("JurassicPark.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Gender");

                    b.Property<string>("Name");

                    b.Property<string>("Species");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}