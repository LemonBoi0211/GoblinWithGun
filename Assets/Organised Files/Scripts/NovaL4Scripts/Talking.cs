using System.Collections;
using UnityEngine;
using TMPro;

public class Talking : MonoBehaviour
{
    // Reference to the TMP text component
    public TMP_Text textDisplay;
    // Reference to the GameObject to hide/show
    public GameObject objectToHide;

    // Define an array of words
    public string[] words = { "I NEED HEALING !!!", "OW", "It's just one goblin", "This will be easy", "ERRRR why is it always goblins" };
    public int randomtalkmin = 0;
    public int randomtalkmax = 6;
    int randontalkchoice;

    void Start()
    {
        // Hide the text and the object at the start
        textDisplay.text = "";
        objectToHide.SetActive(false);

        // Start repeating the EnemyTalking function
        StartCoroutine(RepeatEnemyTalking());
    }

    IEnumerator RepeatEnemyTalking()
    {
        while (true)
        {
            // Randomize the wait time between 3 to 10 seconds
            float waitTime = Random.Range(3f, 10f);
            yield return new WaitForSeconds(waitTime); // Wait for the random wait time
            EnemyTalking(); // Call the EnemyTalking function
        }
    }

    void EnemyTalking()
    {
        // Generate a random index
        int randomIndex = Random.Range(0, words.Length);

        // Choose a word from the array using the random index
        string randomWord = words[randomIndex];

        // Set the chosen word to the TMP text component
        textDisplay.text = randomWord;

        // Show the GameObject
        objectToHide.SetActive(true);

        // Start coroutine to hide the text and GameObject after 3 seconds
        StartCoroutine(HideText());
    }

    IEnumerator HideText()
    {
        // Wait for 3 seconds
        yield return new WaitForSeconds(3f);

        // Clear the text
        textDisplay.text = "";

        // Hide the GameObject
        objectToHide.SetActive(false);
    }
}
