using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

     //Перенести в отдельный класс, если будет такая возможность. 
    public static float BulletSpeed = 35f;
    public byte hitCount;
    public static int ActiveOrb;
    public static bool TwoCount = false;
    public static bool ThreeCount = false;

    [SerializeField]private List<GameObject> bulletObj;
    [SerializeField]private Transform shotPointMain;
    [SerializeField]private Transform shotPoint;
    [SerializeField]private Transform shotPoint2;
    [SerializeField]private Slider hitCountSlider; 
    [SerializeField]private Camera mainCamera;
    [SerializeField]private GlobalSetting globalSetting;

    void Start()
    {
        hitCount = globalSetting.hitCount;
        ActiveOrb = globalSetting.ActiveOrb;
    }

    void Update()
    {
        hitCount = PlayerSataticSet.hitCount;
        HitCountReset();
        if(Time.timeScale == 1f){
            if(Input.GetMouseButtonDown(0)){
                if(PlayerSataticSet.BallCount > 0){
                    MainShotAction();
                    PlayerSataticSet.BallCount -= 1;
                }
            }
        }
    }

    void MainShotAction() {
        RaycastHit hit;
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        
        if(Physics.Raycast(ray, out  hit, 350.0f))
        {
            Instantiate(bulletObj[ActiveOrb], shotPointMain.position, Quaternion.LookRotation(ray.direction));
            if(TwoCount){
                Instantiate(bulletObj[ActiveOrb], shotPoint.position, Quaternion.LookRotation(ray.direction));
                if(ThreeCount){
                    Instantiate(bulletObj[ActiveOrb], shotPoint2.position, Quaternion.LookRotation(ray.direction));
                }
            }
        }
    }

    void HitCountReset(){
        hitCountSlider.value = hitCount;

        if(hitCount == 10 && TwoCount){
            ThreeCount = true;
        }
        if(hitCount == 10){
            TwoCount = true;
            PlayerSataticSet.hitCount = 0;
        }        
    }
}
