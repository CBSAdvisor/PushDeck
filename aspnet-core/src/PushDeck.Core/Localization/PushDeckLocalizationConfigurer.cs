using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace PushDeck.Localization
{
    public static class PushDeckLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(PushDeckConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PushDeckLocalizationConfigurer).GetAssembly(),
                        "PushDeck.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
