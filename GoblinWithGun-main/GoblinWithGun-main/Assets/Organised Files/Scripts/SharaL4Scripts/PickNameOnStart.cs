using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEditor;
using UnityEngine;
using TMPro;

public class PickNameOnStart : MonoBehaviour
{
    public TMP_Text nameText;

    //Array of names
    string[] gamerTags =
        {
            "Goblin_Legend45",
            "GoblinKiller64",
            "XxNoobSlayerxX",
            "MightyShogan42",
            "Sixshots_1Kill",
            "GarlicBreadGamer7",
            "Monster_gamer27",
            "AmberLynx322",
            "NightRider63",
            "SpeedRunner47",
            "Girl_Gamer23",
            "Boy_Gamer74",
            "XxSilentButDeadlyxX",
            "GreacefullChase",
            "DazzleMane82",
            "XxRocketAgentxX",
            "JetStream_Raven",
            "KickStart85",
            "_BoneCracker_",
            "GameQuaker49",
            "SweetPanter",
            "PridePlum40",
            "Dragon_Slayer",
            "InfernoAces",
            "RogueFlyer",
            "CloakedShadow",
            "DinosaurTitan3",
            "TitanCoder41",
            "ArchFox",
            "GoblinSpy",
            "BladeLotus",
            "GeekyGoblin",
            "VenomFury",
            "ShiningGoblin",
            "VintageTanks",
            "ArmoredPixels",
            "VectorHater",
            "SparkingLilac67",
            "DarkJester51",
            "WolfPureBlood",
            "Feedpompano"
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
