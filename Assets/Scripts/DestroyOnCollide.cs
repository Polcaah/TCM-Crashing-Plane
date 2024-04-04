using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollide : MonoBehaviour
{
    private void OnCollisionEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
