using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    GameObject Teach;
    Vector3 newScale;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Teacher"))
        {
            newScale = collision.transform.localScale;
            newScale.x *= -1;
            newScale.y *= -1;
            collision.transform.localScale = newScale;

            collision.GetComponent<Teacher_Movement>().Y_Move *= -1;
            collision.GetComponent<Teacher_Movement>().X_Move *= -1;
        }
    }
}
