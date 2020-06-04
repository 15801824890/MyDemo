﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using demo.Data;

namespace MyDemo.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20200207132557_Company")]
    partial class Company
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MyDemo.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Country")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Industry")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Introduction")
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("Product")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bbdee09c-089b-4d30-bece-44df5923716c"),
                            Country = "USA",
                            Industry = "Software",
                            Introduction = "Great Company",
                            Name = "Microsoft",
                            Product = "Software"
                        },
                        new
                        {
                            Id = new Guid("6fb600c1-9011-4fd7-9234-881379716440"),
                            Country = "USA",
                            Industry = "Internet",
                            Introduction = "Don't be evil",
                            Name = "Google",
                            Product = "Software"
                        },
                        new
                        {
                            Id = new Guid("5efc910b-2f45-43df-afae-620d40542853"),
                            Country = "China",
                            Industry = "Internet",
                            Introduction = "Fubao Company",
                            Name = "Alipapa",
                            Product = "Software"
                        },
                        new
                        {
                            Id = new Guid("bbdee09c-089b-4d30-bece-44df59237100"),
                            Country = "China",
                            Industry = "ECommerce",
                            Introduction = "From Shenzhen",
                            Name = "Tencent",
                            Product = "Software"
                        },
                        new
                        {
                            Id = new Guid("6fb600c1-9011-4fd7-9234-881379716400"),
                            Country = "China",
                            Industry = "Internet",
                            Introduction = "From Beijing",
                            Name = "Baidu",
                            Product = "Software"
                        },
                        new
                        {
                            Id = new Guid("5efc910b-2f45-43df-afae-620d40542800"),
                            Country = "USA",
                            Industry = "Software",
                            Introduction = "Photoshop?",
                            Name = "Adobe",
                            Product = "Software"
                        },
                        new
                        {
                            Id = new Guid("bbdee09c-089b-4d30-bece-44df59237111"),
                            Country = "USA",
                            Industry = "Technology",
                            Introduction = "Wow",
                            Name = "SpaceX",
                            Product = "Rocket"
                        },
                        new
                        {
                            Id = new Guid("6fb600c1-9011-4fd7-9234-881379716411"),
                            Country = "Italy",
                            Industry = "Football",
                            Introduction = "Football Club",
                            Name = "AC Milan",
                            Product = "Football Match"
                        },
                        new
                        {
                            Id = new Guid("5efc910b-2f45-43df-afae-620d40542811"),
                            Country = "China",
                            Industry = "ECommerce",
                            Introduction = "From Jiangsu",
                            Name = "Suning",
                            Product = "Goods"
                        },
                        new
                        {
                            Id = new Guid("bbdee09c-089b-4d30-bece-44df59237122"),
                            Country = "USA",
                            Industry = "Internet",
                            Introduction = "Blocked",
                            Name = "Twitter",
                            Product = "Tweets"
                        },
                        new
                        {
                            Id = new Guid("6fb600c1-9011-4fd7-9234-881379716422"),
                            Country = "USA",
                            Industry = "Internet",
                            Introduction = "Blocked",
                            Name = "Youtube",
                            Product = "Videos"
                        },
                        new
                        {
                            Id = new Guid("5efc910b-2f45-43df-afae-620d40542822"),
                            Country = "China",
                            Industry = "Security",
                            Introduction = "- -",
                            Name = "360",
                            Product = "Security Product"
                        },
                        new
                        {
                            Id = new Guid("bbdee09c-089b-4d30-bece-44df59237133"),
                            Country = "China",
                            Industry = "ECommerce",
                            Introduction = "Brothers",
                            Name = "Jingdong",
                            Product = "Goods"
                        },
                        new
                        {
                            Id = new Guid("6fb600c1-9011-4fd7-9234-881379716433"),
                            Country = "China",
                            Industry = "Internet",
                            Introduction = "Music?",
                            Name = "NetEase",
                            Product = "Songs"
                        },
                        new
                        {
                            Id = new Guid("5efc910b-2f45-43df-afae-620d40542833"),
                            Country = "USA",
                            Industry = "ECommerce",
                            Introduction = "Store",
                            Name = "Amazon",
                            Product = "Books"
                        },
                        new
                        {
                            Id = new Guid("bbdee09c-089b-4d30-bece-44df59237144"),
                            Country = "USA",
                            Industry = "Internet",
                            Introduction = "Not Exists?",
                            Name = "AOL",
                            Product = "Website"
                        },
                        new
                        {
                            Id = new Guid("6fb600c1-9011-4fd7-9234-881379716444"),
                            Country = "USA",
                            Industry = "Internet",
                            Introduction = "Who?",
                            Name = "Yahoo",
                            Product = "Mail"
                        },
                        new
                        {
                            Id = new Guid("5efc910b-2f45-43df-afae-620d40542844"),
                            Country = "USA",
                            Industry = "Internet",
                            Introduction = "Is it a company?",
                            Name = "Firefox",
                            Product = "Browser"
                        });
                });

            modelBuilder.Entity("MyDemo.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EmployeeNo")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4b501cb3-d168-4cc0-b375-48fb33f318a4"),
                            CompanyId = new Guid("bbdee09c-089b-4d30-bece-44df5923716c"),
                            DateOfBirth = new DateTime(1976, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "MSFT231",
                            FirstName = "Nick",
                            Gender = 1,
                            LastName = "Carter"
                        },
                        new
                        {
                            Id = new Guid("7eaa532c-1be5-472c-a738-94fd26e5fad6"),
                            CompanyId = new Guid("bbdee09c-089b-4d30-bece-44df5923716c"),
                            DateOfBirth = new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "MSFT245",
                            FirstName = "Vince",
                            Gender = 1,
                            LastName = "Carter"
                        },
                        new
                        {
                            Id = new Guid("72457e73-ea34-4e02-b575-8d384e82a481"),
                            CompanyId = new Guid("6fb600c1-9011-4fd7-9234-881379716440"),
                            DateOfBirth = new DateTime(1986, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "G003",
                            FirstName = "Mary",
                            Gender = 2,
                            LastName = "King"
                        },
                        new
                        {
                            Id = new Guid("7644b71d-d74e-43e2-ac32-8cbadd7b1c3a"),
                            CompanyId = new Guid("6fb600c1-9011-4fd7-9234-881379716440"),
                            DateOfBirth = new DateTime(1977, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "G097",
                            FirstName = "Kevin",
                            Gender = 1,
                            LastName = "Richardson"
                        },
                        new
                        {
                            Id = new Guid("679dfd33-32e4-4393-b061-f7abb8956f53"),
                            CompanyId = new Guid("5efc910b-2f45-43df-afae-620d40542853"),
                            DateOfBirth = new DateTime(1967, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "A009",
                            FirstName = "卡",
                            Gender = 2,
                            LastName = "里"
                        },
                        new
                        {
                            Id = new Guid("1861341e-b42b-410c-ae21-cf11f36fc574"),
                            CompanyId = new Guid("5efc910b-2f45-43df-afae-620d40542853"),
                            DateOfBirth = new DateTime(1957, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "A404",
                            FirstName = "Not",
                            Gender = 1,
                            LastName = "Man"
                        });
                });

            modelBuilder.Entity("MyDemo.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("varchar(5) CHARACTER SET utf8mb4")
                        .HasMaxLength(5);

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("MyDemo.Entities.TodoItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("TodoItems");
                });

            modelBuilder.Entity("MyDemo.Entities.Employee", b =>
                {
                    b.HasOne("MyDemo.Entities.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
