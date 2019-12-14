using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public string nextScene;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Stage Win");
            collision.GetComponent<Movement>().enabled = false;
            collision.GetComponent<Collider2D>().enabled = false;
            StartCoroutine(StageWin());
        }

    }
    IEnumerator StageWin()
    {
        print(Time.time);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(nextScene);
        print(Time.time);
    }
}
