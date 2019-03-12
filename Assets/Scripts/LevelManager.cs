using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * The LevelManager from the Week 6 Lecture
 */
public class LevelManager : MonoBehaviour {

    public static LevelManager instance;
    public BombController bombCtrl;
    private bool triggered;

    private void Awake()
    {
        // set the instance property/variable to this object
        instance = this;
    }


    public void OnLevelItemTriggerEnter(Collider2D otherColliderInCollision, LevelItemTrigger itemInCollision)
    {
        if(otherColliderInCollision.name == "Character" && itemInCollision.name == "Bomb" && triggered == false)
        {
            //Debug.Log("triggered");
            Timer();
        }
    }

    public void Timer()
    {
        //Debug.Log("timing");
        triggered = true;
        StartCoroutine(bombCtrl.ExplodeCoroutine());
    }

    public void Explode()
    {
        triggered = false;
    }
}
