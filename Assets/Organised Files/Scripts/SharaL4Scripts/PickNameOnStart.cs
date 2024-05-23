using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;

public class PickNameOnStart : MonoBehaviour
{
    public TMP_Text nameText;

    //Array of names
    string[] gamerTags =
        {
            "TheAngloLithuanian",
            "GoblinKiller64",
            "XxNoobSlayerxX",
            "Lieutenant_Dan",
            "6_shots_1Kill",
            "MarioFart",
            "LiquidSnake",
            "TobyTheMinion",
            "MichaelDontLeaveMeHere",
            "cereal_killer",
            "Girl_Gamer23",
            "Fiat_Earther",
            "The'Special'Forces",
            "Bobzilla",
            "Order66",
            "WeGottaGoRevs",
            "KanyeQuest",
            "MixBarLover",
            "AllGoodNamesRGone",
            "Unfinished_sentenc",
            "JK_Growling",
            "JME999",
            "XxxSuperProGamer",
            "AsbestosTasteTester",
            "Born2PoopForced2Wipe",
            "Morbidly_Abeast",
            "Sid_Da_Sloth",
            "Skill_Issue",
            "KimJongHeal",
            "GoblinSpy",
            "$250ForDLC",
            "ItJustWorks",
            "Zinger_Burger",
            "MyPingHigh",
            "VintageTanks",
            "TheDarkerNight",
            "oliverpickup12",
            "DiscordLover",
            "I_AmUrFather",
            "Todd_Coward",
            "SmallLoneOf1Mil$"
        };

    void Start()
    {
        //Finds length of array gamerTags, selects random number between 0 and max size
        //Selects corresponding gamertag
        int maxSize = gamerTags.Length;
        string selectedName = gamerTags[Random.Range(0, maxSize)];
        Debug.Log(selectedName);

        nameText.text = selectedName;
    }
}
