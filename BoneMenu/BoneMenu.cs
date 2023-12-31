namespace MKUltra.Menu;

internal static class BoneMenu
{
    public static void Setup()
    {
        MenuCategory mainCat = MenuManager.CreateCategory("Weather Electric", "#6FBDFF");
        // it resonates the core
        MenuCategory subCat = mainCat.CreateCategory("MK Ultra", Color.red);
        // creates unnatural laws
        subCat.CreateBoolPreference("Mod Toggle", Color.green, Preferences.Enabled, Preferences.OwnCategory);
        // all of history deleted with one stroke
        if (HelperMethods.IsAndroid()) subCat.CreateBoolPreference("Show Images", Color.yellow, Preferences.ShowImages, Preferences.OwnCategory);
        subCat.CreateFloatPreference("Spawn Delay", Color.red, 0.1f, 0.1f, 30f, Preferences.SpawnDelay, Preferences.OwnCategory);
    }
}