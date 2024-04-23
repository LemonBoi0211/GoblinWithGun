using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManager;

public class MainMenu : MonoBehaviour {

    public void PlayGame()
   
    void Start()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

  
   
    {
        public void QuitGame ()
        Debug.Log("Quit!");
        Application.Quit();
   
    }
}
