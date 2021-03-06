// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(WebApplication1Context))]
    [Migration("20220715164326_InitialData")]
    partial class InitialData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Genre");

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Movie");

                    b.HasData(
                        new { ID = 2, Genre = "Romantic Comedy", Price = 7.99m, ReleaseDate = new DateTime(1989, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "When Harry Met Sally" },
                        new { ID = 3, Genre = "Comedy", Price = 8.99m, ReleaseDate = new DateTime(1984, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Ghostbusters " },
                        new { ID = 4, Genre = "Comedy", Price = 9.99m, ReleaseDate = new DateTime(1986, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Ghostbusters 2" },
                        new { ID = 5, Genre = "Western", Price = 3.99m, ReleaseDate = new DateTime(1959, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Rio Bravo" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
