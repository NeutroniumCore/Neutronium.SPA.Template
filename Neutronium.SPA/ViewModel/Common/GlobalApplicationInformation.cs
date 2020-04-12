using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neutronium.BuildingBlocks.Application.ViewModels;

namespace Neutronium.SPA.ViewModel.Common
{
    public class GlobalApplicationInformation
    {
        public static ApplicationInformation Information { get; } = new ApplicationInformation("Neutronium Demo", "David Desmaisons");
    }
}
