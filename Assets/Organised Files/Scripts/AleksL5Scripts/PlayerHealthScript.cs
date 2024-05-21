using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthScript : MonoBehaviour
{
    public float Health = 1f;

    void Update()
    {
        if (Health <= 0)
        {
            Debug.Log("Dead");
            SceneManager.LoadScene(2);
        }
    }
}
