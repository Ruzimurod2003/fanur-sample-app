using FanurApp.Data;
using Microsoft.Extensions.Localization;

namespace FanurApp.Localizers;

public class EFStringLocalizerFactory : IStringLocalizerFactory
{
    public IStringLocalizer Create(Type resourceSource)
    {
        return CreateStringLocalizer();
    }

    public IStringLocalizer Create(string baseName, string location)
    {
        return CreateStringLocalizer();
    }

    private IStringLocalizer CreateStringLocalizer()
    {
        ApplicationContext _db = new ApplicationContext();

        return new EFStringLocalizer(_db);
    }
}