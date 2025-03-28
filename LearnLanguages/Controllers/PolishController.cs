using Languages.Data;
using Microsoft.AspNetCore.Mvc;

namespace LearnLanguages.Controllers
{
    public class PolishController : Controller
    {
        private readonly AppDbContext _context;

        public PolishController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult PhrasesPL()
        {
            var phrases = _context.PhrasesPL.ToList();

            return View(phrases);
        }


        public IActionResult VocabulariesPL()
        {
            var vocabularies = _context.VocabulariesPL.ToList();

            return View(vocabularies);
        }
    }
}
