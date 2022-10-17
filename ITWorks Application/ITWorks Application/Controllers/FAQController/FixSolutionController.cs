using ITWorks_Application.Controllers.api;
using ITWorks_Application.Models;
using ITWorks_Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.Controllers
{
    public class FixSolutionController : Controller
    {
        private readonly FAQRepo repo;
        public FixSolutionController()
        {
            repo = new FAQRepo();
        }

        public FixSolutionViewModel fixSolutionViewModel { get; set; }
        [Route("FixSolution/FixSolutionIndex/{FixID}")]
        public IActionResult FixSolutionIndex(int FixID)
        {
            if (fixSolutionViewModel == null)
                fixSolutionViewModel = new FixSolutionViewModel();

            fixSolutionViewModel.fixModel = repo.GetFixData(FixID);
            if(fixSolutionViewModel.fixModel != null)
            {
                List<FixInstructionData> fixInstructionModels = repo.GetFixInstruction(FixID);
                fixSolutionViewModel.fixInstruction = repo.GetInstructions(fixInstructionModels);
            }


            return View(fixSolutionViewModel);
        }
    }
}
