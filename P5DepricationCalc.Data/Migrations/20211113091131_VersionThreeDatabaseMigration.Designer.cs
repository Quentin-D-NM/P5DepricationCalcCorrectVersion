// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P5DepricationCalc.Data.Models;

namespace P5DepricationCalc.Data.Migrations
{
    [DbContext(typeof(AssetDbContext))]
    [Migration("20211113091131_VersionThreeDatabaseMigration")]
    partial class VersionThreeDatabaseMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("P5DepricationCalc.Data.Models.MyAsset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateIn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("TEXT");

                    b.Property<double>("InitValue")
                        .HasColumnType("REAL");

                    b.Property<double>("SalvageValue")
                        .HasColumnType("REAL");

                    b.Property<int>("UsefullLife")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("MyAssets");
                });
#pragma warning restore 612, 618
        }
    }
}
