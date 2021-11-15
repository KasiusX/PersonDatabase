using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonDatabaseLogic.PersonLogic;

namespace PersonDatabaseWebApplication.Pages.People
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Person NewPerson { get; set; }
        private PersonController personController = new PersonController();
        public string errorMessage = "";
        public void OnGet()
        {
            NewPerson = new Person();
        }

        public IActionResult OnPost()
        {
            try
            {
                personController.AddPerson(NewPerson);
                return Redirect("/Index");
            } 
            catch (ValidationException e)
            {
                errorMessage = e.Message;
                return Page();       
            }
        }
    }
}
