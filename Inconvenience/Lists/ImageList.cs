using Random = System.Random;

namespace MKUltra.Inconvenience.Lists;

public class ImageList
{
    private readonly List<string> Items = new()
    {
        "alcoholic.png",
        "byeah.png",
        "cam.png",
        "canes.png",
        "cat.png",
        "ceilingman.png",
        "cigarrette.png",
        "deadend.png",
        "dog1.png",
        "dog2.png",
        "donald.png",
        "eclipse.jpg",
        "eggs.png",
        "EPICCAT.jpg",
        "firehat.png",
        "gallium.png",
        "gay.png",
        "gay2.png",
        "googoozaza.png",
        "gun.png",
        "him.png",
        "huh.png",
        "IDK.jpg",
        "image.png",
        "KATSUP.png",
        "keyboardbed.png",
        "metrocop.png",
        "mingus.png",
        "paralyzer.png",
        "pasta.png",
        "police.png",
        "pornsites.png",
        "raccoon.png",
        "rizz.png",
        "skeleton.jpg",
        "stupid.png",
        "thecolorsbrothers.png",
        "thesog.png",
        "thuggin.jpg",
        "thumbworld.png",
        "tookyears.jpg",
        "toothpaste.png"
    };

    private readonly List<string> UsedItems = new();
    
    public byte[] GetImage()
    {
        if (Items.Count == 0)
        {
            if (UsedItems.Count == 0)
            {
                MelonLogger.Error("Somehow, both lists are empty.");
            }
            Items.AddRange(UsedItems);
            UsedItems.Clear();
        }
        var rand = new Random();
        var randomIndex = rand.Next(0, Items.Count);
        var selectedItem = Items[randomIndex];
        var bytes = HelperMethods.GetResourceBytes(Main.CurrAsm, selectedItem);
        Items.RemoveAt(randomIndex);
        UsedItems.Add(selectedItem);
        return bytes;
    }
}