using ITWorks_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.ViewModels
{
    public class FixSolutionViewModel
    {
        public FixData fixModel { get; set; }
        public List<InstructionData> fixInstruction { get; set; }
}
}
