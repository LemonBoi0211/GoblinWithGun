using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{

    void Start()
    {

    }



    public void Quit()
    {
        Debug.Log("Quit!");
        Application.Quit();

    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}

