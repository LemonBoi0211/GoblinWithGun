using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthBarScript : MonoBehaviour
{
    //1 = 100% health     0 = 0% health  
    public PlayerHealthScript PlayerHealthScript;
    public RectTransform Size;
   
    // Update is called once per frame
    void Update()
    {
        if (PlayerHealthScript != null)
        {
            Size.localScale = new Vector3(5f * PlayerHealthScript.Health, 0.4f, 0f);
        }
    }


}