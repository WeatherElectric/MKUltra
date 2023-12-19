using BoneLib.RandomShit;
using MKUltra.Inconvenience.Lists;
using MKUltra.Melon;
using Random = UnityEngine.Random;

namespace MKUltra.Inconvenience.Managers;

[RegisterTypeInIl2Cpp]
public class InconvenienceManager : MonoBehaviour
{
    public static InconvenienceManager Instance { get; private set; }
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        Instance = this;
        switch (HelperMethods.IsAndroid())
        {
            case true:
            {
                MelonCoroutines.Start(QuestCoroutine());
                break;
            }
            case false:
            {
                MelonCoroutines.Start(PCCoroutine());
                break;
            }
        }
    }

    private static IEnumerator PCCoroutine()
    {
        while (true)
        {
            if (Main.LevelLoaded)
            {
                yield return new WaitForSeconds(Preferences.SpawnDelay.Value);
                if (Preferences.Enabled.Value)
                {
                    var rand = Random.Range(0, 1);
                    switch (rand)
                    {
                        case 0:
                        {
                            PopupBoxManager.CreateNewPopupBox(StringList.GetString());
                            break;
                        }
                        case 1:
                        {
                            PopupBoxManager.CreateNewImagePopup(ImageList.GetImage());
                            break;
                        }
                        default:
                        {
                            ModConsole.Error("Random is null?");
                            break;
                        }
                    }
                }
            }
            else
            {
                yield return null;
            }
        }
        // ReSharper disable once IteratorNeverReturns
    }
    
    private static IEnumerator QuestCoroutine()
    {
        while (true)
        {
            if (Main.LevelLoaded)
            {
                yield return new WaitForSeconds(Preferences.SpawnDelay.Value);
                if (Preferences.Enabled.Value)
                {
                    if (Preferences.ShowImages.Value)
                    {
                        var rand = Random.Range(0, 1);
                        switch (rand)
                        {
                            case 0:
                            {
                                PopupBoxManager.CreateNewPopupBox(StringList.GetString());
                                break;
                            }
                            case 1:
                            {
                                PopupBoxManager.CreateNewImagePopup(ImageList.GetImage());
                                break;
                            }
                            default:
                            {
                                ModConsole.Error("Random is null?");
                                break;
                            }
                        }
                    }
                    else
                    {
                        PopupBoxManager.CreateNewPopupBox(StringList.GetString());
                    }
                }
            }
            else
            {
                yield return null;
            }
        }
        // ReSharper disable once IteratorNeverReturns
    }
    
    public InconvenienceManager(IntPtr ptr) : base(ptr) {}
}