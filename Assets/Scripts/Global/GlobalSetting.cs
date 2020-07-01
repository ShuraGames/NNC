using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GlobalSetting", menuName = "Setting/GlobalSetting", order = 0)]
public class GlobalSetting : ScriptableObject {

    public int StartBallCount = 20;
    public byte hitCount = 0;
    public int ActiveOrb = 0;
    public byte percentBuffSpawn = 5;
    public byte countScoreDef = 0;



    //MainSetting
    public float musicVoumeInSetting;
    public float graphicQualityInSetting;
    public int maxScoreCount;
    public int maxScoreCountMainMenu;

}

