[assembly: AssemblyTitle(MKUltra.Main.Description)]
[assembly: AssemblyDescription(MKUltra.Main.Description)]
[assembly: AssemblyCompany(MKUltra.Main.Company)]
[assembly: AssemblyProduct(MKUltra.Main.Name)]
[assembly: AssemblyCopyright("Developed by " + MKUltra.Main.Author)]
[assembly: AssemblyTrademark(MKUltra.Main.Company)]
[assembly: AssemblyVersion(MKUltra.Main.Version)]
[assembly: AssemblyFileVersion(MKUltra.Main.Version)]
[assembly:
    MelonInfo(typeof(MKUltra.Main), MKUltra.Main.Name, MKUltra.Main.Version,
        MKUltra.Main.Author, MKUltra.Main.DownloadLink)]
[assembly: MelonColor(System.ConsoleColor.White)]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("Stress Level Zero", "BONELAB")]