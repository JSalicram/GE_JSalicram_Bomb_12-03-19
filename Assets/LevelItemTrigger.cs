using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelItemTrigger : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D otherColliderInCollision)
    {
        Debug.Log(otherColliderInCollision + " entered the trigger of " + this.name);

        LevelManager.instance.OnLevelItemTriggerEnter(otherColliderInCollision, this);
    }
}
