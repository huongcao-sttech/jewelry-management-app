using MyProject.Debugging;

namespace MyProject;

public class MyProjectConsts
{
    public const string LocalizationSourceName = "MyProject";

    public const string ConnectionStringName = "Default";

    public const bool MultiTenancyEnabled = true;


    /// <summary>
    /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
    /// </summary>
    public static readonly string DefaultPassPhrase =
        DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "ae8f8fb4cf554b3f95586cefe6993ca8";
}
