// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StateApprove.Data;

#nullable disable

namespace StateApprove.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20220920140155_adddbb")]
    partial class adddbb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StateApprove.Data.BaseCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("BaseCompanies");
                });

            modelBuilder.Entity("StateApprove.Data.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BaseCompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BaseCompanyId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("StateApprove.Data.Stage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sequence")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Stages");
                });

            modelBuilder.Entity("StateApprove.Data.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<double>("AmountTo")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StageId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("StateApprove.Data.BaseCompany", b =>
                {
                    b.HasOne("StateApprove.Data.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("StateApprove.Data.Company", b =>
                {
                    b.HasOne("StateApprove.Data.BaseCompany", null)
                        .WithMany("Companies")
                        .HasForeignKey("BaseCompanyId");
                });

            modelBuilder.Entity("StateApprove.Data.Stage", b =>
                {
                    b.HasOne("StateApprove.Data.Company", "Company")
                        .WithMany("StageList")
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("StateApprove.Data.User", b =>
                {
                    b.HasOne("StateApprove.Data.Stage", "Stage")
                        .WithMany("UserList")
                        .HasForeignKey("StageId");

                    b.Navigation("Stage");
                });

            modelBuilder.Entity("StateApprove.Data.BaseCompany", b =>
                {
                    b.Navigation("Companies");
                });

            modelBuilder.Entity("StateApprove.Data.Company", b =>
                {
                    b.Navigation("StageList");
                });

            modelBuilder.Entity("StateApprove.Data.Stage", b =>
                {
                    b.Navigation("UserList");
                });
#pragma warning restore 612, 618
        }
    }
}
