﻿// <auto-generated />
using System;
using CHILDCARE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CHILDCARE.Migrations
{
    [DbContext(typeof(CHILDCAREContext))]
    partial class CHILDCAREContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("childcare")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CHILDCARE.Models.rpt_ccs_provider", b =>
                {
                    b.Property<string>("vendor_code_addr")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("address_code");

                    b.Property<string>("notes");

                    b.Property<string>("physical_addr_line_1");

                    b.Property<string>("physical_addr_line_2");

                    b.Property<string>("physical_address_combined");

                    b.Property<string>("physical_city");

                    b.Property<string>("physical_city_state_zip");

                    b.Property<string>("physical_state");

                    b.Property<string>("physical_zip");

                    b.Property<DateTime>("prov_accred_exp_date");

                    b.Property<DateTime>("prov_accred_recd_date");

                    b.Property<DateTime>("prov_accred_req_date");

                    b.Property<DateTime>("prov_inspect_exp_date");

                    b.Property<DateTime>("prov_inspect_recd_date");

                    b.Property<DateTime>("prov_inspect_req_date");

                    b.Property<DateTime>("prov_lic_exp_date");

                    b.Property<DateTime>("prov_lic_recd_date");

                    b.Property<DateTime>("prov_lic_req_date");

                    b.Property<string>("prov_staff_background_check");

                    b.Property<string>("provider_accreditation");

                    b.Property<string>("provider_email_1");

                    b.Property<string>("provider_email_2");

                    b.Property<string>("provider_fax");

                    b.Property<string>("provider_inspection");

                    b.Property<string>("provider_license");

                    b.Property<string>("provider_phone");

                    b.Property<string>("provider_program");

                    b.Property<string>("provider_status_ccs");

                    b.Property<string>("provider_status_peg");

                    b.Property<string>("remit_addr_line_1");

                    b.Property<string>("remit_addr_line_2");

                    b.Property<string>("remit_address_combined");

                    b.Property<string>("remit_city");

                    b.Property<string>("remit_state");

                    b.Property<string>("remit_zip");

                    b.Property<string>("tin");

                    b.Property<string>("vendor_code");

                    b.Property<string>("vendor_name");

                    b.HasKey("vendor_code_addr");

                    b.ToTable("rpt_ccs_provider");
                });
#pragma warning restore 612, 618
        }
    }
}
