﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tickets.DAL.Context;

#nullable disable

namespace Tickets.DAL.Migrations
{
    [DbContext(typeof(TicketsContext))]
    partial class TicketsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Tickets.DAL.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Severity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = 20,
                            Description = "Harum hic impedit dolore voluptate placeat.",
                            Severity = 1,
                            Title = "in"
                        },
                        new
                        {
                            Id = 1,
                            Description = "Rerum totam est quo possimus sunt sunt ad.",
                            Severity = 0,
                            Title = "id"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Id cumque explicabo beatae.",
                            Severity = 1,
                            Title = "dicta"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Consectetur beatae dolorem voluptates occaecati.",
                            Severity = 0,
                            Title = "eius"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Nulla est doloribus ut non aspernatur vero dolores.",
                            Severity = 2,
                            Title = "assumenda"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Et praesentium est ipsum eligendi rerum itaque voluptate quia.",
                            Severity = 1,
                            Title = "ex"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Optio non debitis ut molestiae dolorem ad.",
                            Severity = 2,
                            Title = "velit"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Dolor quae iure quas error est.",
                            Severity = 2,
                            Title = "voluptas"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Iste molestiae aut inventore necessitatibus necessitatibus perspiciatis sit.",
                            Severity = 2,
                            Title = "recusandae"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Voluptas expedita placeat ad sint consequuntur.",
                            Severity = 0,
                            Title = "qui"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Voluptates qui sed aliquid laudantium in.",
                            Severity = 0,
                            Title = "autem"
                        },
                        new
                        {
                            Id = 11,
                            Description = "Placeat non repellat qui libero.",
                            Severity = 1,
                            Title = "totam"
                        },
                        new
                        {
                            Id = 12,
                            Description = "Debitis vero laborum asperiores deserunt nihil tempora quia.",
                            Severity = 2,
                            Title = "enim"
                        },
                        new
                        {
                            Id = 13,
                            Description = "Voluptatibus a et natus ipsa at quis rem dolores.",
                            Severity = 0,
                            Title = "natus"
                        },
                        new
                        {
                            Id = 14,
                            Description = "Dolorem qui animi sint ad facere ut ullam voluptatem repellendus.",
                            Severity = 1,
                            Title = "et"
                        },
                        new
                        {
                            Id = 15,
                            Description = "Sint suscipit delectus accusamus distinctio earum aliquam.",
                            Severity = 2,
                            Title = "aut"
                        },
                        new
                        {
                            Id = 16,
                            Description = "Et vel tempora.",
                            Severity = 0,
                            Title = "et"
                        },
                        new
                        {
                            Id = 17,
                            Description = "Aut atque officiis numquam mollitia voluptas dolore.",
                            Severity = 1,
                            Title = "iusto"
                        },
                        new
                        {
                            Id = 18,
                            Description = "Ipsum mollitia sit officiis sapiente natus.",
                            Severity = 2,
                            Title = "facere"
                        },
                        new
                        {
                            Id = 19,
                            Description = "Inventore aut reprehenderit vitae ratione dolorum harum.",
                            Severity = 2,
                            Title = "recusandae"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
