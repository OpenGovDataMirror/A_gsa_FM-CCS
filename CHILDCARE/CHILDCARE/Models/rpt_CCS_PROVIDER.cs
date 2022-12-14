using System.ComponentModel.DataAnnotations;


namespace CHILDCARE.Models
{
    public class rpt_ccs_provider
    {
        [Key]

        [Display(Name = "VENDOR CODE/ADDR")]
        public string vendor_code_addr { get; set; }
        [Display(Name = "VENDOR CODE")]
        public string vendor_code { get; set; }
        [Display(Name = "ADDRESS CODE")]
        public string address_code { get; set; }
        [Display(Name = "VENDOR NAME")]
        public string vendor_name { get; set; }
        [Display(Name = "TIN")]
        public string tin { get; set; }
        [Display(Name = "PHYSICAL ADDR LINE 1")]
        public string physical_addr_line_1 { get; set; }
        [Display(Name = "PHYSICAL ADDR LINE 2")]
        public string physical_addr_line_2 { get; set; }
        [Display(Name = "PHYSICAL CITY STATE ZIP")]
        public string physical_city_state_zip { get; set; }
        [Display(Name = "PHYSICAL CITY")]
        public string physical_city { get; set; }
        [Display(Name = "PHYSICAL STATE")]
        public string physical_state { get; set; }
        [Display(Name = "PHYSICAL ZIP")]
        public string physical_zip { get; set; }
        [Display(Name = "PROVIDER E-MAIL-1")]
        public string provider_email_1 { get; set; }
        [Display(Name = "PROVIDER PHONE")]
        public string provider_phone { get; set; }
        [Display(Name = "PROVIDER FAX")]
        public string provider_fax { get; set; }
        [Display(Name = "PROVIDER E-MAIL-2")]
        public string provider_email_2 { get; set; }
        [Display(Name = "REMIT ADDR LINE 1")]
        public string remit_addr_line_1 { get; set; }
        [Display(Name = "REMIT ADDR LINE 2")]
        public string remit_addr_line_2 { get; set; }
        [Display(Name = "REMIT CITY")]
        public string remit_city { get; set; }
        [Display(Name = "REMIT STATE")]
        public string remit_state { get; set; }
        [Display(Name = "REMIT ZIP")]
        public string remit_zip { get; set; }
        [Display(Name = "REMIT ADDRESS COMBINED")]
        public string remit_address_combined { get; set; }
        [Display(Name = "PHYSICAL ADDRESS COMBINED")]
        public string physical_address_combined { get; set; }
        [Display(Name = "PROVIDER PROGRAM")]
        public string provider_program { get; set; }
        [Display(Name = "PROVIDER LICENSE")]
        public string provider_license { get; set; }
        [Display(Name = "PROV LIC RECD DATE")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime prov_lic_recd_date { get; set; }
        [Display(Name = "PROV LIC EXP DATE")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime prov_lic_exp_date { get; set; }
        [Display(Name = "PROV LIC REQ DATE")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime prov_lic_req_date { get; set; }
        [Display(Name = "PROVIDER ACCREDITATION")]
        public string provider_accreditation { get; set; }
        [Display(Name = "PROV ACCRED RECD DATE")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime prov_accred_recd_date { get; set; }
        [Display(Name = "PROV ACCRED EXP DATE")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime prov_accred_exp_date { get; set; }
        [Display(Name = "PROV ACCRED REQ DATE")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime prov_accred_req_date { get; set; }
        [Display(Name = "PROVIDER INSPECTION")]
        public string provider_inspection { get; set; }
        [Display(Name = "PROV INSPECT RECD DATE")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime prov_inspect_recd_date { get; set; }
        [Display(Name = "PROV INSPECT EXP DATE")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime prov_inspect_exp_date { get; set; }
        [Display(Name = "PROV INSPECT REQ DATE")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime prov_inspect_req_date { get; set; }
        [Display(Name = "PROV STAFF BACKGROUND CHECK")]
        public string prov_staff_background_check { get; set; }
        [Display(Name = "PROVIDER STATUS PEG")]
        public string provider_status_peg { get; set; }
        [Display(Name = "PROVIDER STATUS CCS")]
        public string provider_status_ccs { get; set; }
        [Display(Name = "NOTES")]
        public string notes { get; set; }
    }
}
