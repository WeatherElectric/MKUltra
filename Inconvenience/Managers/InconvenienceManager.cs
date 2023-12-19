using BoneLib.RandomShit;
using Harmony;
using MKUltra.Inconvenience.Cleanup;
using Random = UnityEngine.Random;

namespace MKUltra.Inconvenience.Managers;

[RegisterTypeInIl2Cpp]
public class InconvenienceManager : MonoBehaviour
{
    public static InconvenienceManager Instance { get; private set; }

    private ImageList _imageList;
    private StringList _stringList;
    
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        ModConsole.Msg("Sent to DontDestroyOnLoad", 1);
        Instance = this;
        ModConsole.Msg("Instance set", 1);
        _imageList = new ImageList();
        ModConsole.Msg("ImageList created", 1);
        _stringList = new StringList();
        ModConsole.Msg("StringList created", 1);
        
        switch (HelperMethods.IsAndroid())
        {
            case true:
            {
                MelonCoroutines.Start(QuestCoroutine());
                ModConsole.Msg("Started QuestCoroutine", 1);
                break;
            }
            case false:
            {
                MelonCoroutines.Start(PCCoroutine());
                ModConsole.Msg("Started PCCoroutine", 1);
                break;
            }
        }
    }

    private IEnumerator PCCoroutine()
    {
        while (true)
        {
            if (Main.LevelLoaded)
            {
                yield return new WaitForSeconds(Preferences.SpawnDelay.Value);
                if (Preferences.Enabled.Value)
                {
                    var rand = Random.Range(0, 100);
                    if (rand >= 50)
                    {
                        var go = PopupBoxManager.CreateNewPopupBox(_stringList.GetString());
                        ModConsole.Msg("Created popupbox", 1);
                        go.AddComponent<TheJanitor>();
                        ModConsole.Msg("Gave the janitor a new task", 1);
                    }
                    else
                    {
                        var go = PopupBoxManager.CreateNewImagePopup(_imageList.GetImage());
                        ModConsole.Msg("Created imagepopup", 1);
                        go.AddComponent<TheJanitor>();
                        ModConsole.Msg("Gave the janitor a new task", 1);
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
    
    private IEnumerator QuestCoroutine()
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
                        var rand = Random.Range(0, 100);
                        if (rand >= 50)
                        {
                            var go = PopupBoxManager.CreateNewPopupBox(_stringList.GetString());
                            ModConsole.Msg("Created popupbox", 1);
                            go.AddComponent<TheJanitor>();
                            ModConsole.Msg("Gave the janitor a new task", 1);
                        }
                        else
                        {
                            var go = PopupBoxManager.CreateNewImagePopup(_imageList.GetImage());
                            ModConsole.Msg("Created imagepopup", 1);
                            go.AddComponent<TheJanitor>();
                            ModConsole.Msg("Gave the janitor a new task", 1);
                        }
                    }
                    else
                    {
                        var go = PopupBoxManager.CreateNewPopupBox(_stringList.GetString());
                        ModConsole.Msg("Created popupbox", 1);
                        go.AddComponent<TheJanitor>();
                        ModConsole.Msg("Gave the janitor a new task", 1);
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