using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject To_Unlock;
    public GameObject To_Lock;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        To_Unlock.SetActive(true);
        To_Lock.SetActive(false);
        Destroy(gameObject);
    }
}
