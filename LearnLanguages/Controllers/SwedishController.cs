using Languages.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LearnLanguages.Controllers
{
    public class SwedishController : Controller
    {


        private readonly AppDbContext _context;

        public SwedishController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult PhrasesSE()
        {
            var phrases = _context.PhrasesSE.ToList();

            return View(phrases);
        }


        public IActionResult VocabulariesSE()
        {
            var vocabularies = _context.VocabulariesSE.ToList();

            return View(vocabularies);
        }
    }
}
