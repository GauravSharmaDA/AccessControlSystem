using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AccessControlSystem.Core;

namespace AccessControlSystem.Core.Migrations
{
    [DbContext(typeof(AccessControlSystemContext))]
    partial class AccessControlSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AccessControlSystem.Core.AccessPolicy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Policies");
                });

            modelBuilder.Entity("AccessControlSystem.Core.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Departmetns");
                });

            modelBuilder.Entity("AccessControlSystem.Core.Server", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DepartmentId");

                    b.Property<string>("Name");

                    b.Property<int?>("PolicyId");

                    b.Property<int?>("ServerTypeId");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("PolicyId");

                    b.HasIndex("ServerTypeId");

                    b.ToTable("Servers");
                });

            modelBuilder.Entity("AccessControlSystem.Core.ServerType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ServerTypes");
                });

            modelBuilder.Entity("AccessControlSystem.Core.Server", b =>
                {
                    b.HasOne("AccessControlSystem.Core.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.HasOne("AccessControlSystem.Core.AccessPolicy", "Policy")
                        .WithMany()
                        .HasForeignKey("PolicyId");

                    b.HasOne("AccessControlSystem.Core.ServerType", "ServerType")
                        .WithMany()
                        .HasForeignKey("ServerTypeId");
                });
        }
    }
}
