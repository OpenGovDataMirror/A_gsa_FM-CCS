using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CHILDCARE.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "childcare");

            migrationBuilder.CreateTable(
                name: "rpt_ccs_provider",
                schema: "childcare",
                columns: table => new
                {
                    vendor_code_addr = table.Column<string>(nullable: false),
                    vendor_code = table.Column<string>(nullable: true),
                    address_code = table.Column<string>(nullable: true),
                    vendor_name = table.Column<string>(nullable: true),
                    tin = table.Column<string>(nullable: true),
                    physical_addr_line_1 = table.Column<string>(nullable: true),
                    physical_addr_line_2 = table.Column<string>(nullable: true),
                    physical_city_state_zip = table.Column<string>(nullable: true),
                    physical_city = table.Column<string>(nullable: true),
                    physical_state = table.Column<string>(nullable: true),
                    physical_zip = table.Column<string>(nullable: true),
                    provider_email_1 = table.Column<string>(nullable: true),
                    provider_phone = table.Column<string>(nullable: true),
                    provider_fax = table.Column<string>(nullable: true),
                    provider_email_2 = table.Column<string>(nullable: true),
                    remit_addr_line_1 = table.Column<string>(nullable: true),
                    remit_addr_line_2 = table.Column<string>(nullable: true),
                    remit_city = table.Column<string>(nullable: true),
                    remit_state = table.Column<string>(nullable: true),
                    remit_zip = table.Column<string>(nullable: true),
                    remit_address_combined = table.Column<string>(nullable: true),
                    physical_address_combined = table.Column<string>(nullable: true),
                    provider_program = table.Column<string>(nullable: true),
                    provider_license = table.Column<string>(nullable: true),
                    prov_lic_recd_date = table.Column<DateTime>(nullable: false),
                    prov_lic_exp_date = table.Column<DateTime>(nullable: false),
                    prov_lic_req_date = table.Column<DateTime>(nullable: false),
                    provider_accreditation = table.Column<string>(nullable: true),
                    prov_accred_recd_date = table.Column<DateTime>(nullable: false),
                    prov_accred_exp_date = table.Column<DateTime>(nullable: false),
                    prov_accred_req_date = table.Column<DateTime>(nullable: false),
                    provider_inspection = table.Column<string>(nullable: true),
                    prov_inspect_recd_date = table.Column<DateTime>(nullable: false),
                    prov_inspect_exp_date = table.Column<DateTime>(nullable: false),
                    prov_inspect_req_date = table.Column<DateTime>(nullable: false),
                    prov_staff_background_check = table.Column<string>(nullable: true),
                    provider_status_peg = table.Column<string>(nullable: true),
                    provider_status_ccs = table.Column<string>(nullable: true),
                    notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rpt_ccs_provider", x => x.vendor_code_addr);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "rpt_ccs_provider",
                schema: "childcare");
        }
    }
}
