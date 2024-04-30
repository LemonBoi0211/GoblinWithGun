using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBarScript : MonoBehaviour
{

    //1 = 100% health     0 = 0% health  
    public EnemyMeleeScript meleeEnemyScript;
    public EnemyWizardScript wizardEnemyScript;
    public RectTransform Size;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (meleeEnemyScript != null)
        { 
          Size.localScale = new Vector3 (5f * meleeEnemyScript.Health, 0.4f, 0f);
        }
        if (wizardEnemyScript != null)
        {
            Size.localScale = new Vector3(5f * wizardEnemyScript.Health, 0.4f, 0f);
        }
    }
}
