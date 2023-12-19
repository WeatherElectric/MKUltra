namespace MKUltra;

public class Main : MelonMod
{
    internal const string Name = "MKUltra";
    internal const string Description = "Supreme Torture";
    internal const string Author = "SoulWithMae";
    internal const string Company = "Weather Electric";
    internal const string Version = "1.0.0";
    internal const string DownloadLink = null;
    
    internal static Assembly CurrAsm { get; private set; }
    internal static bool LevelLoaded { get; private set; }
    

    public override void OnInitializeMelon()
    {
        CurrAsm = Assembly.GetExecutingAssembly();
        ModConsole.Setup(LoggerInstance);
        Preferences.Setup();
        BoneMenu.Setup();
        Hooking.OnLevelInitialized += OnLevelLoad;
        Hooking.OnLevelUnloaded += OnLevelUnload;
    }

    private static void OnLevelLoad(LevelInfo levelInfo)
    {
        LevelLoaded = true;
        if (InconvenienceManager.Instance != null) return;
        var go = new GameObject("Inconvenience Manager");
        go.AddComponent<InconvenienceManager>();
    }

    private static void OnLevelUnload()
    {
        LevelLoaded = false;
    }
}