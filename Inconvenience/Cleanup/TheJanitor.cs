﻿namespace MKUltra.Inconvenience.Cleanup;

[RegisterTypeInIl2Cpp]
public class TheJanitor : MonoBehaviour
{
    private void Start()
    {
        MelonCoroutines.Start(Despawn());
    }

    private IEnumerator Despawn()
    {
        yield return new WaitForSeconds(15f);
        ModConsole.Msg($"Janitor's cleaning {gameObject.name}", 1);
        Destroy(gameObject);
    }
    
    public TheJanitor(IntPtr ptr) : base(ptr) {}
}