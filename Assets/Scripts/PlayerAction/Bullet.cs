using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField]private PlayerAttack Attack;
    [SerializeField]private int damageMain;
    [SerializeField]private int damageFire;
    [SerializeField]private int damageElectro;
    [SerializeField]private int damagePurple;
    [SerializeField]private GameObject hitEffect;

    void Update()
    {
        MoveBullet();
    }

    void MoveBullet(){
        transform.Translate(Vector3.forward * PlayerAttack.BulletSpeed * Time.deltaTime);
        Destroy(gameObject, 10f);
    }   

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "EnemyElectro" ){
            SetDamageEnemy(other, damageElectro, hitEffect);
        }
        else if(other.tag == "EnemyFire" ){
            SetDamageEnemy(other, damageFire, hitEffect);
        }
        else if(other.tag == "EnemyPurple" ){
            SetDamageEnemy(other, damagePurple, hitEffect);
        } 
        else if(other.tag == "Enemy" || other.tag == "Glass"){
            SetDamageEnemy(other, damageMain, hitEffect);
        } 
        else if(other.tag == "WALL"){
            SetDamageEnemy(other, damageMain, hitEffect);
        } 
    }

    void SetDamageEnemy(Collider other, int damage, GameObject muzzle){
        if(other.tag == "WALL"){
            CreateHit();
            Destroy(gameObject);
        } 
        else if(other.tag == "Enemy" || other.tag == "EnemyPurple" || other.tag == "EnemyFire" || other.tag == "EnemyElectro") 
        {
            if(other.GetComponent<RandomBuffEffect>().ActiveEffect){ 
                PlayerAttack.ActiveOrb = other.GetComponent<RandomBuffEffect>().BuffNomber + 1;
            }
            other.GetComponent<DefaultEnemy>().healthEnemy -= damage;
            CreateHit();
            Destroy(gameObject);
        } 
        else if(other.tag == "Glass"){              
            other.GetComponent<GlassDeath>().lifeGlass -= damage;  
            other.GetComponent<GlassDeath>().GetComponent<Animation>().Play();
            CreateHit();
            Destroy(gameObject); 
        } 
        else
        {
            Destroy(gameObject, 10);
        }
    }

    void CreateHit(){
        var hit = Instantiate(hitEffect, transform.position, Quaternion.identity);
        ParticleSystem psHit = hitEffect.GetComponent<ParticleSystem>();

        Destroy(hit, psHit.main.duration);
    }
}
