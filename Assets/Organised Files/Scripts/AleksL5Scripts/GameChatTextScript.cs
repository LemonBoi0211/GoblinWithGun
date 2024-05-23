using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameChatTextScript : MonoBehaviour
{
    public TMP_Text nameText;
    string[] gamerTags =
      {
            "GoblinKiller64: Go to www.NotAScam.com for free Gamebux",
            "TheAngloLithuanian: Good looting lads",
            "TheAngloLithuanian: Go to the left",
             "TheAngloLithuanian: Finally",
            "GoblinKiller64: Go to www.NotAScam.com for free Gamebux",
            "XxNoobSlayerxX: Ugh I hate how long these dungeons take",
             "XxNoobSlayerxX: Touch grass mate",
            "12_12_12: Did you die to a skeleton? Skill issue",
            "JK_Growling: I'm heading off, see ya",
            "JME999: Can someone ban GoblinKiller64 for spam?",
           "GoblinKiller64: Go to www.NotAScam.com for free Gamebux",
            "AsbestosTasteTester: Why did you take my loot?",
             "AsbestosTasteTester: Sup dude",
            "Born2PoopForced2Wipe: Lol",
            "Morbidly_Abeast: Finally reached level 10. poggers",
            "Sid_Da_Sloth: Anyone else really laggy?",
            "Skill_Issue: Is that gun ammo? Since when did they add that?",
            "Skill_Issue: Hi guys!",
            "GoblinKiller64: Go to www.NotAScam.com for free Gamebux",
            "GoblinSpy: Why am I seeing guns in the goblin dungeons?",
            "$250ForDLC: Sorry guys, mum said I must go to sleep",
            "ItJustWorks: L",
            "Zinger_Burger: Hello everyone!",
            "GoblinKiller64: Go to www.NotAScam.com for free Gamebux",
             "VintageTanks: Ugh i'll ragequit soon",
             "VintageTanks: I hate this game!",
            "TheDarkerNight: Can we wrap this up? I got work soon",
             "GoblinKiller64: Go to www.NotAScam.com for free Gamebux",
            "DiscordLover: I'm considering using Teams",
            "I_AmUrFather: Nice name lol",
            "I_AmUrFather: Anyone find the game too ez?",
            "Todd_Coward: Goblins seem too easy to kill tbh",
             "Todd_Coward: Gj man",
             "GoblinKiller64: Go to www.NotAScam.com for free Gamebux",
        };

    public int Position;
    private RectTransform Transform;
    public GameObject ChatManager;
    public GameChatManagerScript ChatManagerScript;

    void Awake()
    {
        ChatManager = GameObject.FindGameObjectWithTag("ChatManager");
        ChatManagerScript = ChatManager.GetComponent<GameChatManagerScript>();
        Transform = GetComponent<RectTransform>();



        int maxSize = gamerTags.Length;
        string selectedName = gamerTags[Random.Range(0, maxSize)];

        nameText.text = selectedName;
    }

    // Update is called once per frame
    void Update()
    {
        if (Position == 1)
        {
            Transform.anchoredPosition = new Vector2(23.12576f, -20.9f);
        }
        if (Position == 2)
        {
            Transform.anchoredPosition = new Vector2(23.12576f, -18.18f);
        }
        if (Position == 3)
        {
            Transform.anchoredPosition = new Vector2(23.12576f, -15.29f);
        }
        if (Position == 4)
        {
            Destroy(gameObject);
        }
        if (ChatManagerScript.NewText == true)
        {
            Position += 1;
        }
    }

   
  

 
}
