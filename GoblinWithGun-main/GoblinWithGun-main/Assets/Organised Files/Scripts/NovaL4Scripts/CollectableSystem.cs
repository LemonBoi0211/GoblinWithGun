using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableSystem : MonoBehaviour
{
    public PlayerHealthScript currentHP;
    public Text collectableAText;
    public Text collectableBText;
    public Text collectableCText;
    public Text collectableDText;
    public Text collectableEText;
    public int RifleAmmo = 5;
    public int RocketAmmo = 5;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("CollectableA"))
        {  
            currentHP.Health = 1f;
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("CollectableB"))
        {
            RifleAmmo++;        
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("CollectableC"))
        {
            RocketAmmo++;    
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("CollectableD"))
        {          
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("CollectableE"))
        {        
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
}