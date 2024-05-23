using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            SceneManager.LoadScene(3);
        }
    }

        // Update is called once per frame
        void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 0.4f));
    }
}
