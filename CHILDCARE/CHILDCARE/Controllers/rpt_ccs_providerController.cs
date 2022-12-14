using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CHILDCARE.Models;

namespace CHILDCARE.Controllers
{
    public class rpt_ccs_providerController : Controller
    {
        private readonly CHILDCAREContext _context;

        public rpt_ccs_providerController(CHILDCAREContext context)
        {
            _context = context;
        }

        // GET: rpt_ccs_provider
        public async Task<IActionResult> Index()
        {
            return View(await _context.rpt_ccs_provider.ToListAsync());
        }

        // GET: rpt_ccs_provider/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rpt_ccs_provider = await _context.rpt_ccs_provider
                .FirstOrDefaultAsync(m => m.vendor_code_addr == id);
            if (rpt_ccs_provider == null)
            {
                return NotFound();
            }

            return View(rpt_ccs_provider);
         }

        // GET: rpt_ccs_provider/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: rpt_ccs_provider/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("vendor_code_addr,vendor_code,address_code,vendor_name,tin,physical_addr_line_1,physical_addr_line_2,physical_city_state_zip,physical_city,physical_state,physical_zip,provider_email_1,provider_phone,provider_fax,provider_email_2,remit_addr_line_1,remit_addr_line_2,remit_city,remit_state,remit_zip,remit_address_combined,physical_address_combined,provider_program,provider_license,prov_lic_recd_date,prov_lic_exp_date,prov_lic_req_date,provider_accreditation,prov_accred_recd_date,prov_accred_exp_date,prov_accred_req_date,provider_inspection,prov_inspect_recd_date,prov_inspect_exp_date,prov_inspect_req_date,prov_staff_background_check,provider_status_peg,provider_status_ccs,notes")] rpt_ccs_provider rpt_ccs_provider)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rpt_ccs_provider);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rpt_ccs_provider);
        }

        // GET: rpt_ccs_provider/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rpt_ccs_provider = await _context.rpt_ccs_provider.FindAsync(id);
            if (rpt_ccs_provider == null)
            {
                return NotFound();
            }
            return View(rpt_ccs_provider);
        }

        // POST: rpt_ccs_provider/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("vendor_code_addr,vendor_code,address_code,vendor_name,tin,physical_addr_line_1,physical_addr_line_2,physical_city_state_zip,physical_city,physical_state,physical_zip,provider_email_1,provider_phone,provider_fax,provider_email_2,remit_addr_line_1,remit_addr_line_2,remit_city,remit_state,remit_zip,remit_address_combined,physical_address_combined,provider_program,provider_license,prov_lic_recd_date,prov_lic_exp_date,prov_lic_req_date,provider_accreditation,prov_accred_recd_date,prov_accred_exp_date,prov_accred_req_date,provider_inspection,prov_inspect_recd_date,prov_inspect_exp_date,prov_inspect_req_date,prov_staff_background_check,provider_status_peg,provider_status_ccs,notes")] rpt_ccs_provider rpt_ccs_provider)
        {
            if (id != rpt_ccs_provider.vendor_code_addr)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rpt_ccs_provider);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!rpt_ccs_providerExists(rpt_ccs_provider.vendor_code_addr))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(rpt_ccs_provider);
        }

        // GET: rpt_ccs_provider/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rpt_ccs_provider = await _context.rpt_ccs_provider
                .FirstOrDefaultAsync(m => m.vendor_code_addr == id);
            if (rpt_ccs_provider == null)
            {
                return NotFound();
            }

            return View(rpt_ccs_provider);
        }

        // POST: rpt_ccs_provider/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var rpt_ccs_provider = await _context.rpt_ccs_provider.FindAsync(id);
            _context.rpt_ccs_provider.Remove(rpt_ccs_provider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool rpt_ccs_providerExists(string id)
        {
            return _context.rpt_ccs_provider.Any(e => e.vendor_code_addr == id);
        }
    }
}
