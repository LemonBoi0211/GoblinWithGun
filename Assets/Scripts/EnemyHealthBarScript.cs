using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBarScript : MonoBehaviour
{

    //1 = 100% health     0 = 0% health  
    public EnemyHealthScript EnemyHealthScript;
    public RectTransform Size;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyHealthScript != null)
        { 
          Size.localScale = new Vector3 (5f * EnemyHealthScript.Health, 0.4f, 0f);
        }
    }
}
