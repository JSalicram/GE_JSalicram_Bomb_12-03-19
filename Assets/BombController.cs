using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour {
    private GameObject Bomb;
    float shake = 0.1f;
    private Vector2 bombPos;
    private float bombRadius;

    public Collider2D[] objectsInZone;

    private void Start()
    {
        Bomb = gameObject;
        bombPos = this.transform.position;
        //bombRadius = GetComponent<Collider2D>();
    }

    public IEnumerator ExplodeCoroutine()
    {
        float rndmTime = Random.Range(20, 50);
        //random number between 20 and 50

        for (float f = rndmTime; f >= 0; f -= 1f)
        {
            Bomb.transform.Translate(shake, 0, 0);
            shake = shake * -1;
            yield return new WaitForSeconds(0.05f);
        }

        LevelManager.instance.Explode();
    }

    /*
    Collider2D[] collidersInBombRadius = Physics2D.OverlapCircleAll(Transform.position, )
    {
        for(int i = 0; i<collidersInBombRadius, i++)
        {
            if(collidersInBombRadius[i] != this.gameObject)
            {
                Destroy(colliderInBombRadius[i].gameobject);
            }
        }
    }*/
}
