// ReSharper disable MemberCanBePrivate.Global, these categories may be used outside of this namespace to create bonemenu options.

namespace MKUltra.Melon;

internal static class Preferences
{
    public static readonly MelonPreferences_Category GlobalCategory = MelonPreferences.CreateCategory("Global");
    public static readonly MelonPreferences_Category OwnCategory = MelonPreferences.CreateCategory("MKUltra");

    public static MelonPreferences_Entry<int> LoggingMode { get; set; }
    public static MelonPreferences_Entry<float> SpawnDelay { get; set; }
    public static MelonPreferences_Entry<bool> Enabled { get; set; }
    public static MelonPreferences_Entry<bool> ShowImages { get; set; }

    public static void Setup()
    {
        LoggingMode = GlobalCategory.GetEntry<int>("LoggingMode") ?? GlobalCategory.CreateEntry("LoggingMode", 0, "Logging Mode", "The level of logging to use. 0 = Important Only, 1 = All");
        GlobalCategory.SetFilePath(MelonUtils.UserDataDirectory + "/WeatherElectric.cfg");
        GlobalCategory.SaveToFile(false);
        Enabled = OwnCategory.GetEntry<bool>("Enabled") ?? OwnCategory.CreateEntry("Enabled", true, "Enabled", "Whether or not the mod is enabled.");
        SpawnDelay = OwnCategory.GetEntry<float>("SpawnDelay") ?? OwnCategory.CreateEntry("SpawnDelay", 5f, "Spawn Delay", "The delay between each text spawn.");
        if (HelperMethods.IsAndroid()) ShowImages = OwnCategory.GetEntry<bool>("ShowImages") ?? OwnCategory.CreateEntry("ShowImages", false, "Show Images", "Whether or not to show images. It can cause a lagspike whenever images spawn, so this is off by default. Of course, this is a problem specific to the Quest.");
        OwnCategory.SetFilePath(MelonUtils.UserDataDirectory + "/WeatherElectric.cfg");
        OwnCategory.SaveToFile(false);
        ModConsole.Msg("Finished preferences setup for MKUltra", 1);
    }
}