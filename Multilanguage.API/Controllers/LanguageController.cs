using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Linq;

namespace Multilanguage.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        IStringLocalizer<Language> localizer;

        public LanguageController(IStringLocalizer<Language> localizer)
        {
            this.localizer = localizer;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(localizer.GetAllStrings().Select(e => new { e.Name, e.Value }));
        }
    }
}
