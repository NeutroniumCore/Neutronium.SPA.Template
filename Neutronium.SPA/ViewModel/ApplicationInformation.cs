using System.Reflection;

namespace Neutronium.SPA.ViewModel 
{
    public class ApplicationInformation
    {
        public string Name => "Neutronium Vuetify SPA";

        public string Version => Assembly.GetExecutingAssembly().GetName().Version.ToString();;

        public string MadeBy => "David Desmaisons";

        public int Year => 2017;
    }
}
