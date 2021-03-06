// <auto-generated />
using GourmetPizza.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GourmetPizza.Migrations
{
    [DbContext(typeof(GourmetPizzaContext))]
    partial class GourmetPizzaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10");

            modelBuilder.Entity("GourmetPizza.Models.Pizza", b =>
                {
                    b.Property<int>("PizzaType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PizzaName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("PizzaType");

                    b.ToTable("Pizza");
                });
#pragma warning restore 612, 618
        }
    }
}
