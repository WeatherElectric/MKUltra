namespace MKUltra.Menu;

internal static class BoneMenu
{
    public static void Setup()
    {
        MenuCategory mainCat = MenuManager.CreateCategory("Weather Electric", "#6FBDFF");
        MenuCategory subCat = mainCat.CreateCategory("Oh Hell Yeah", Color.red);
        subCat.CreateBoolPreference("Mod Toggle", Color.green, Preferences.Enabled, Preferences.OwnCategory);
        if (HelperMethods.IsAndroid()) subCat.CreateBoolPreference("Show Images", Color.yellow, Preferences.ShowImages, Preferences.OwnCategory);
        subCat.CreateFloatPreference("Spawn Delay", Color.red, 0.1f, 0.1f, 30f, Preferences.SpawnDelay, Preferences.OwnCategory);
    }
}