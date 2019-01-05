using Vm.Tools.Application.ViewModel;

namespace Neutronium.SPA.ViewModel.Pages 
{
    public class AboutViewModel 
    {
        public ApplicationInformation Information { get; } = new ApplicationInformation("Neutronium Demo", "David Desmaisons");

        public string[] Descriptions { get; } =
        {
            Resource.About1,
            Resource.About2,
            Resource.About3
        };
    }
}
