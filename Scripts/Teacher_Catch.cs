using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teacher_Catch : MonoBehaviour
{
    public GameObject Icon;

    // Start is called before the first frame update
    void Start()
    {
        Icon.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Student Caught");
            collision.GetComponent<Movement>().enabled = false;
            collision.GetComponent<Collider2D>().enabled = false;
            this.gameObject.GetComponent<Teacher_Movement>().enabled = false;
            Icon.SetActive(true);
            StartCoroutine(Reload());
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
    IEnumerator Reload()
    {
        print(Time.time);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        print(Time.time);
    }
}
