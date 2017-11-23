using System.Threading.Tasks;

namespace Neutronium.SPA.Application.WindowServices
{
    public interface IMessageBox 
    {
        Task<bool> ShowMessage(ConfirmationMessage confirmationMessage);

        void ShowInformation(MessageInformation messageInformation);
    }
}