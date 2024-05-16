using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CanvasScript : MonoBehaviour
{
   
    private Transform parentTransform;
    private Vector3 originalScale;

    void Start()
    {
    
        parentTransform = transform.parent;
        originalScale = transform.localScale;
    }

    void Update()
    {
        if (parentTransform.localScale.x < 0)
        {
            transform.localScale = new Vector3(-originalScale.x, originalScale.y, originalScale.z);
        }
        else
        {
            transform.localScale = originalScale;
        }

       transform.position = parentTransform.position;
    }
}
