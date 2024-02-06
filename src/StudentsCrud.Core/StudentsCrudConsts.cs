using StudentsCrud.Debugging;

namespace StudentsCrud
{
    public class StudentsCrudConsts
    {
        public const string LocalizationSourceName = "StudentsCrud";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "7b39cf530fd44146b509984fbbe0b3e1";
    }
}
