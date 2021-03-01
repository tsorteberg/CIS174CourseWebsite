﻿// <auto-generated />
using CIS174CourseWebsite.Areas.M6T3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CIS174CourseWebsite.Migrations.Country
{
    [DbContext(typeof(CountryContext))]
    [Migration("20210301063355_m6t3initial")]
    partial class m6t3initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CIS174CourseWebsite.Areas.M6T3.Models.Category", b =>
                {
                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = "indoor",
                            Name = "Indoor"
                        },
                        new
                        {
                            CategoryID = "outdoor",
                            Name = "Outdoor"
                        });
                });

            modelBuilder.Entity("CIS174CourseWebsite.Areas.M6T3.Models.Country", b =>
                {
                    b.Property<string>("CountryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LogoImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("GameID");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryID = "canada",
                            CategoryID = "indoor",
                            GameID = "winter",
                            LogoImage = "M6T3/canada.png",
                            Name = "Canada"
                        },
                        new
                        {
                            CountryID = "sweden",
                            CategoryID = "indoor",
                            GameID = "winter",
                            LogoImage = "M6T3/sweden.png",
                            Name = "Sweden"
                        },
                        new
                        {
                            CountryID = "greatbritain",
                            CategoryID = "indoor",
                            GameID = "winter",
                            LogoImage = "M6T3/greatbritain.png",
                            Name = "Great Britain"
                        },
                        new
                        {
                            CountryID = "jamaica",
                            CategoryID = "outdoor",
                            GameID = "winter",
                            LogoImage = "M6T3/jamaica.png",
                            Name = "Jamaica"
                        },
                        new
                        {
                            CountryID = "italy",
                            CategoryID = "outdoor",
                            GameID = "winter",
                            LogoImage = "M6T3/italy.png",
                            Name = "Italy"
                        },
                        new
                        {
                            CountryID = "japan",
                            CategoryID = "outdoor",
                            GameID = "winter",
                            LogoImage = "M6T3/japan.png",
                            Name = "Japan"
                        },
                        new
                        {
                            CountryID = "germany",
                            CategoryID = "indoor",
                            GameID = "summer",
                            LogoImage = "M6T3/germany.png",
                            Name = "Germany"
                        },
                        new
                        {
                            CountryID = "china",
                            CategoryID = "indoor",
                            GameID = "summer",
                            LogoImage = "M6T3/china.png",
                            Name = "China"
                        },
                        new
                        {
                            CountryID = "mexico",
                            CategoryID = "indoor",
                            GameID = "summer",
                            LogoImage = "M6T3/mexico.png",
                            Name = "Mexico"
                        },
                        new
                        {
                            CountryID = "brazil",
                            CategoryID = "outdoor",
                            GameID = "summer",
                            LogoImage = "M6T3/brazil.png",
                            Name = "Brazil"
                        },
                        new
                        {
                            CountryID = "netherlands",
                            CategoryID = "outdoor",
                            GameID = "summer",
                            LogoImage = "M6T3/netherlands.png",
                            Name = "Netherlands"
                        },
                        new
                        {
                            CountryID = "usa",
                            CategoryID = "outdoor",
                            GameID = "summer",
                            LogoImage = "M6T3/usa.png",
                            Name = "USA"
                        },
                        new
                        {
                            CountryID = "thailand",
                            CategoryID = "indoor",
                            GameID = "para",
                            LogoImage = "M6T3/thailand.png",
                            Name = "Thailand"
                        },
                        new
                        {
                            CountryID = "uruguay",
                            CategoryID = "indoor",
                            GameID = "para",
                            LogoImage = "M6T3/uruguay.png",
                            Name = "Uruguay"
                        },
                        new
                        {
                            CountryID = "ukraine",
                            CategoryID = "indoor",
                            GameID = "para",
                            LogoImage = "M6T3/ukraine.png",
                            Name = "Ukraine"
                        },
                        new
                        {
                            CountryID = "austria",
                            CategoryID = "outdoor",
                            GameID = "para",
                            LogoImage = "M6T3/austria.png",
                            Name = "Austria"
                        },
                        new
                        {
                            CountryID = "pakistan",
                            CategoryID = "outdoor",
                            GameID = "para",
                            LogoImage = "M6T3/pakistan.png",
                            Name = "Pakistan"
                        },
                        new
                        {
                            CountryID = "zimbabwe",
                            CategoryID = "outdoor",
                            GameID = "para",
                            LogoImage = "M6T3/zimbabwe.png",
                            Name = "Zimbabwe"
                        },
                        new
                        {
                            CountryID = "france",
                            CategoryID = "indoor",
                            GameID = "youth",
                            LogoImage = "M6T3/france.png",
                            Name = "France"
                        },
                        new
                        {
                            CountryID = "cyprus",
                            CategoryID = "indoor",
                            GameID = "youth",
                            LogoImage = "M6T3/cyprus.png",
                            Name = "Cyprus"
                        },
                        new
                        {
                            CountryID = "russia",
                            CategoryID = "indoor",
                            GameID = "youth",
                            LogoImage = "M6T3/russia.png",
                            Name = "Russia"
                        },
                        new
                        {
                            CountryID = "finland",
                            CategoryID = "outdoor",
                            GameID = "youth",
                            LogoImage = "M6T3/finland.png",
                            Name = "Finland"
                        },
                        new
                        {
                            CountryID = "slovakia",
                            CategoryID = "outdoor",
                            GameID = "youth",
                            LogoImage = "M6T3/slovakia.png",
                            Name = "Slovakia"
                        },
                        new
                        {
                            CountryID = "portugal",
                            CategoryID = "outdoor",
                            GameID = "youth",
                            LogoImage = "M6T3/portugal.png",
                            Name = "Portugal"
                        });
                });

            modelBuilder.Entity("CIS174CourseWebsite.Areas.M6T3.Models.Game", b =>
                {
                    b.Property<string>("GameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameID");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameID = "winter",
                            Name = "Winter Olympics"
                        },
                        new
                        {
                            GameID = "summer",
                            Name = "Summer Olympics"
                        },
                        new
                        {
                            GameID = "para",
                            Name = "Paraympics"
                        },
                        new
                        {
                            GameID = "youth",
                            Name = "Youth Olympic Games"
                        });
                });

            modelBuilder.Entity("CIS174CourseWebsite.Areas.M6T3.Models.Country", b =>
                {
                    b.HasOne("CIS174CourseWebsite.Areas.M6T3.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID");

                    b.HasOne("CIS174CourseWebsite.Areas.M6T3.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameID");
                });
#pragma warning restore 612, 618
        }
    }
}
