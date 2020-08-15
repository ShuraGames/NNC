using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBuffEffect : MonoBehaviour
{
    public int BuffNomber {
        get{
            return buffNomber;
        }
        set {
            if(value >= 0){
                buffNomber = value;
            }
        }
    }
    private bool activeEffect = false;
    public bool ActiveEffect {
        get {
            return activeEffect;
        }
        set {
            activeEffect = value;
        }
    }
 
    [SerializeField] private int buffNomber = 5;
    [SerializeField] private byte Chanse = 0;
    [SerializeField] private List<GameObject> buffEffect;
    [SerializeField] private GlobalSetting globalSetting;

    void Start()
    {
        if(buffNomber == 0)
        {
            buffNomber = Random.Range(0, 3);
        }
        if(Chanse == 0)
        {
            Chanse = globalSetting.percentBuffSpawn;
        }
        RandomFuckEffect();
    }

    void RandomFuckEffect()
    {
        var percent = Random.Range(0, 100);

        if( percent <= Chanse )
        {
            activeEffect = true;            
            buffEffect[buffNomber].SetActive(true);
        }
    }
}
