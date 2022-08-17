using UnityEngine;

public class Sector_Finish : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.TryGetComponent(out Player player)) return;
        player.ReachedFinish();
    }
}
