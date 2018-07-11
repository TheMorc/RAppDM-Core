// lil cuz i can
// Morc, circa 2017 😅
namespace RAppDM
{

    public class RepoItem
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public string IconURL { get; set; }
        public string Description { get; set; }
        public string SilentArgument { get; set; }
        public string Category { get; set; }
        public string Version { get; set; }
        public string Size { get; set; }
    }


    public class RAppDM_internal
    {
        public static string type = AppType.Alpha;
        public static System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
        public static string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        public static string shortversion = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location).FileVersion;

        internal static string GetVersion()
        {
            return $"{version}{type}";
        }

        internal static string GetShortVersion()
        {
            return $"{shortversion}{type}";
        }
    }

    public class AppType
    {
        public static string Alpha => "a";
        public static string Beta => "b";
        public static string Release => "r";
    }
}
