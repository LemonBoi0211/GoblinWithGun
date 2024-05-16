/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableSystemNova : MonoBehaviour
{
    public Text collectableAText;
    public Text collectableBText;
    public Text collectableCText;
    public Text collectableDText;
    public Text collectableEText;

    private int collectableACount = 0;
    private int collectableBCount = 0;
    private int collectableCCount = 0;
    private int collectableDCount = 0;
    private int collectableECount = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("CollectableA"))
        {
            collectableACount++;
            UpdateText(collectableAText, collectableACount);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("CollectableB"))
        {
            collectableBCount++;
            UpdateText(collectableBText, collectableBCount);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("CollectableC"))
        {
            collectableCCount++;
            UpdateText(collectableCText, collectableCCount);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("CollectableD"))
        {
            collectableDCount++;
            UpdateText(collectableDText, collectableDCount);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("CollectableE"))
        {
            collectableECount++;
            UpdateText(collectableEText, collectableECount);
            Destroy(other.gameObject);
        }
    }

    private void UpdateText(Text textObject, int value)
    {
        if (textObject != null)
        {
            textObject.text = value.ToString();
        }
    }
}*/