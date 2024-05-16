using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CanvasScript : MonoBehaviour
{
    public Transform Target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Target != null)
        {
            this.transform.position = Target.position;
        }

        if (Target == null)
        {
            Destroy(gameObject);
        }
    }
}
