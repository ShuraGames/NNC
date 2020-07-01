using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBuffEffect : MonoBehaviour
{
    private int buffNomber;
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
 
    private byte Chanse;

    [Header("List buff")]
    [SerializeField]List<GameObject> buffEffect;
    [SerializeField]private GlobalSetting globalSetting;

    void Start()
    {
        buffNomber = Random.Range(0, 3);
        Chanse = globalSetting.percentBuffSpawn;
        RandomFuckEffect();
    }

    void RandomFuckEffect(){
        int percent = Random.Range(0, 100);

        if( percent <= Chanse ){
            activeEffect = true;            
            buffEffect[buffNomber].SetActive(true);
            Debug.Log((buffNomber).ToString() + " :Active " + buffEffect[buffNomber].name);
        }
    }
}
