using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechangewin : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if collided with the object you want to trigger movement
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(0);
        }

    }
}
