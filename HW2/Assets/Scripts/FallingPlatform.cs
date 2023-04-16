using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    private float destroyDelay = 3f;

    [SerializeField]
    private Rigidbody2D rigidBody;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rigidBody.bodyType = RigidbodyType2D.Dynamic;
            Destroy(gameObject, destroyDelay);
        }
    }

    
}

