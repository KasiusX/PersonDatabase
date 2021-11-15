using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonDatabaseLogic.PersonLogic;

namespace PersonDatabaseWebApplication.Pages.People
{
    public class DeteleModel : PageModel
    {
        public Person PersonToDelete { get; set; }
        private PersonController personController;

        public DeteleModel()
        {
            this.personController = new PersonController();
        }

        public IActionResult OnGet(int? id)            
        {
            if (id == null)
                return NotFound();
            
            PersonToDelete = personController.GetPeople().Where(x => x.Id == id).First();

            return Page();
        }

        public IActionResult OnPost(int id)
        {
            personController.DeletePerson(id);
            return RedirectToPage("/Index");
        }
    }
}
