using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BPCalculator.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public BloodPressure BP { get; set; }

        public void OnGet()
        {
            BP = new BloodPressure
            {
                Systolic = 100,
                Diastolic = 60
            };
        }

        public IActionResult OnPost()
        {
            if (BP.Systolic <= BP.Diastolic)
            {
                ModelState.AddModelError("", "Systolic must be greater than Diastolic");
                return Page();
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Category is computed automatically
            return Page();
        }
    }
}
