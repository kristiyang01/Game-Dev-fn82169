using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    public Image collectedKey;
    public Image fullKey;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("key acquired");
            Destroy(gameObject);
            collectedKey.sprite = fullKey.sprite;

        }
    }
}
