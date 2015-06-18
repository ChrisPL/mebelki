using System.Globalization;
using System.Net.NetworkInformation;
using System.Resources;

namespace MebelkiModel
{
    public class ModelResourceManager
    {
        public static CultureInfo Culture = CultureInfo.GetCultureInfo("en-GB");
        private static readonly ResourceManager Manager = new ResourceManager("MebelkiModel.Resource.res",typeof(MebelkiModel.ModelResourceManager).Assembly);

        public static string GetString(string resourceName)
        {
            return Manager.GetString(resourceName,Culture);
        }
    }
}