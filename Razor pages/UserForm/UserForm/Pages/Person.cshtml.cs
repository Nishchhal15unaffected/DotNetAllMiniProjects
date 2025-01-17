using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UserForm.Pages
{
    public class PersonModel : PageModel
    {
        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]
        public bool Active { get; set; }

        public List<string> messages = new List<string>();
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var message = $"{FirstName} {LastName} Address is added";
            messages.Add(message);
            return Page();
        }
    }
}
