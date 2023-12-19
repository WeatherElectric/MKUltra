namespace MKUltra.Inconvenience.Cleanup;

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
        Destroy(gameObject);
    }
    
    public TheJanitor(IntPtr ptr) : base(ptr) {}
}