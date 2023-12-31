namespace MKUltra;

public class Main : MelonMod
{
    internal const string Name = "MKUltra";
    internal const string Description = "How much longer until you break?";
    internal const string Author = "SoulWithMae";
    internal const string Company = "Weather Electric";
    internal const string Version = "1.0.0";
    internal const string DownloadLink = null;
    
    internal static Assembly CurrAsm { get; private set; }
    internal static bool LevelLoaded { get; private set; }
    

    public override void OnInitializeMelon()
    {
        CurrAsm = Assembly.GetExecutingAssembly();
        // how much deception can you take?
        ModConsole.Setup(LoggerInstance);
        Preferences.Setup();
        BoneMenu.Setup();
        // how many lies will you create?
        Hooking.OnLevelInitialized += OnLevelLoad;
        Hooking.OnLevelUnloaded += OnLevelUnload;
        // your mind's about to fall
        // and they're breaking through
    }

    private static void OnLevelLoad(LevelInfo levelInfo)
    {
        LevelLoaded = true;
        if (InconvenienceManager.Instance != null) return;
        var go = new GameObject("Inconvenience Manager");
        ModConsole.Msg("Created Inconvenience Manager since it did not exist before.", 1);
        // go, be free, fuck over random people because I hate people
        go.AddComponent<InconvenienceManager>();
    }

    private static void OnLevelUnload()
    {
        LevelLoaded = false;
    }
}