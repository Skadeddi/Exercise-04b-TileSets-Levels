using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("bruh");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
