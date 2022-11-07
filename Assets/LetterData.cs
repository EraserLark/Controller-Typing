using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterData : MonoBehaviour
{
    public List<LetterGroup> presets;
    LetterGroup a2z = new LetterGroup("A to Z", "ABCD EFGH", "IJKL MNOP", "QRST UVWX", "YZ.! ?,+-");
    LetterGroup qwerty = new LetterGroup("QWERTY", "QWER TYUI", "OPAS DFGH", "JKL; ZXCV", "BNM, .?!-");
    LetterGroup useRanking = new LetterGroup("Use Ranking","ETAO INSH", "RDLC UMWF", "GYPB VKJX", "QZ.! ?,+-");
    LetterGroup holiday = new LetterGroup("Happy Holidays", "PRES ENTS", "SNOW FALL", "REIN DEER", "HANU KKAH");

    private void Awake()
    {
        presets = new List<LetterGroup>();
        presets.Add(a2z);
        presets.Add(qwerty);
        presets.Add(useRanking);
        presets.Add(holiday);
    }
}

public struct LetterGroup
{
    public string[] axisGroup;
    public string groupName;

    public LetterGroup(string name, string northChars, string eastChars, string southChars, string westChars)
    {
        axisGroup = new string[4];
        axisGroup[0] = northChars;
        axisGroup[1] = eastChars;
        axisGroup[2] = southChars;
        axisGroup[3] = westChars;

        groupName = name;
    }
}
