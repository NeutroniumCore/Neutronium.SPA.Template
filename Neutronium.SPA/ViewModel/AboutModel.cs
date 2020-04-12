using Neutronium.BuildingBlocks.Application.ViewModels;
using Neutronium.SPA.ViewModel.Common;

namespace Neutronium.SPA.ViewModel 
{
    /// <summary>
    /// ViewModel for the "about" route
    /// </summary>
    public class AboutViewModel
    {
        public ApplicationInformation Information => GlobalApplicationInformation.Information;

        public string[] Descriptions { get; } =
        {
            Resource.About1,
            Resource.About2,
            Resource.About3
        };
    }
}
