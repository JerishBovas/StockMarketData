﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockMarketCollector.Data;

#nullable disable

namespace StockMarketCollector.Migrations
{
    [DbContext(typeof(StockMarketContext))]
    partial class StockMarketContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StockMarketCollector.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cusip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Dcf")
                        .HasColumnType("float");

                    b.Property<double>("DcfDiff")
                        .HasColumnType("float");

                    b.Property<bool>("DefaultImage")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FullTimeEmployees")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Industry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("IpoDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Isin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("LastDiv")
                        .HasColumnType("float");

                    b.Property<double>("MarketCap")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Range")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StockId")
                        .HasColumnType("int");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StockId")
                        .IsUnique();

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("StockMarketCollector.Models.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<long>("AvgVolume")
                        .HasColumnType("bigint");

                    b.Property<double>("Change")
                        .HasColumnType("float");

                    b.Property<double>("ChangesPercentage")
                        .HasColumnType("float");

                    b.Property<double>("DayHigh")
                        .HasColumnType("float");

                    b.Property<double>("DayLow")
                        .HasColumnType("float");

                    b.Property<DateTime>("EarningsAnnouncement")
                        .HasColumnType("datetime2");

                    b.Property<double>("Eps")
                        .HasColumnType("float");

                    b.Property<long>("MarketCap")
                        .HasColumnType("bigint");

                    b.Property<double>("Open")
                        .HasColumnType("float");

                    b.Property<double>("Pe")
                        .HasColumnType("float");

                    b.Property<double>("PreviousClose")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("PriceAvg200")
                        .HasColumnType("float");

                    b.Property<double>("PriceAvg50")
                        .HasColumnType("float");

                    b.Property<long>("SharesOutstanding")
                        .HasColumnType("bigint");

                    b.Property<int>("StockId")
                        .HasColumnType("int");

                    b.Property<long>("Timestamp")
                        .HasColumnType("bigint");

                    b.Property<long>("Volume")
                        .HasColumnType("bigint");

                    b.Property<double>("YearHigh")
                        .HasColumnType("float");

                    b.Property<double>("YearLow")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("StockId")
                        .IsUnique();

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("StockMarketCollector.Models.RealTimePrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("AskPrice")
                        .HasColumnType("float");

                    b.Property<double>("AskSize")
                        .HasColumnType("float");

                    b.Property<double>("BidPrice")
                        .HasColumnType("float");

                    b.Property<double>("BidSize")
                        .HasColumnType("float");

                    b.Property<double>("FmpLast")
                        .HasColumnType("float");

                    b.Property<double>("LastSalePrice")
                        .HasColumnType("float");

                    b.Property<double>("LastSaleSize")
                        .HasColumnType("float");

                    b.Property<DateTime>("LastSaleTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("StockId")
                        .HasColumnType("int");

                    b.Property<double>("Volume")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("StockId")
                        .IsUnique();

                    b.ToTable("RealTimePrices");
                });

            modelBuilder.Entity("StockMarketCollector.Models.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActivelyTrading")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdr")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEtf")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFund")
                        .HasColumnType("bit");

                    b.Property<double>("LastDiv")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Range")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StockExchangeId")
                        .HasColumnType("int");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StockExchangeId");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("StockMarketCollector.Models.StockExchange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClosingHour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpeningHour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeZone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StockExchanges");
                });

            modelBuilder.Entity("StockMarketCollector.Models.Company", b =>
                {
                    b.HasOne("StockMarketCollector.Models.Stock", "Stock")
                        .WithOne("Company")
                        .HasForeignKey("StockMarketCollector.Models.Company", "StockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("StockMarketCollector.Models.Quote", b =>
                {
                    b.HasOne("StockMarketCollector.Models.Stock", "Stock")
                        .WithOne("Quote")
                        .HasForeignKey("StockMarketCollector.Models.Quote", "StockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("StockMarketCollector.Models.RealTimePrice", b =>
                {
                    b.HasOne("StockMarketCollector.Models.Stock", "Stock")
                        .WithOne("RealTimePrice")
                        .HasForeignKey("StockMarketCollector.Models.RealTimePrice", "StockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("StockMarketCollector.Models.Stock", b =>
                {
                    b.HasOne("StockMarketCollector.Models.StockExchange", "StockExchange")
                        .WithMany("Stocks")
                        .HasForeignKey("StockExchangeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StockExchange");
                });

            modelBuilder.Entity("StockMarketCollector.Models.Stock", b =>
                {
                    b.Navigation("Company");

                    b.Navigation("Quote");

                    b.Navigation("RealTimePrice");
                });

            modelBuilder.Entity("StockMarketCollector.Models.StockExchange", b =>
                {
                    b.Navigation("Stocks");
                });
#pragma warning restore 612, 618
        }
    }
}
