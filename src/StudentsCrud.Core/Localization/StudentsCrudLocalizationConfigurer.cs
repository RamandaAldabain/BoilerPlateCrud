using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace StudentsCrud.Localization
{
    public static class StudentsCrudLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(StudentsCrudConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(StudentsCrudLocalizationConfigurer).GetAssembly(),
                        "StudentsCrud.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
