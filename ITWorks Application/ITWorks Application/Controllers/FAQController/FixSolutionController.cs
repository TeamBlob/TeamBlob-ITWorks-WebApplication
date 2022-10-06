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
        public FixSolutionViewModel fixSolutionViewModel { get; set; }
        [Route("FixSolution/FixSolutionIndex/{FixID}")]
        public IActionResult FixSolutionIndex(int FixID)
        {
            if (fixSolutionViewModel == null)
                fixSolutionViewModel = new FixSolutionViewModel();

            fixSolutionViewModel.fixModel = FakeDataController.list_of_fixModel.FirstOrDefault(x => x.FixID == FixID);
            if(fixSolutionViewModel.fixModel != null)
            {
                List<FixInstructionData> fixInstructionModels = FakeDataController.list_of_fixInstruction.Where(x => x.FixID == FixID).ToList();
                fixSolutionViewModel.fixInstruction = FakeDataController.list_of_instruction.Intersect(FakeDataController.list_of_instruction.Where(k => fixInstructionModels.Any(x => x.InstructionID == k.InstructionID))).ToList();
            }


            return View(fixSolutionViewModel);
        }
    }
}
