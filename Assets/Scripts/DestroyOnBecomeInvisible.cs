using UnityEngine;

public class DestroyOnBecomeInvisible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}
