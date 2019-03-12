using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour {
    private GameObject Bomb;
    float shake = 0.1f;

    private void Start()
    {
        Bomb = gameObject;
    }

    public IEnumerator ExplodeCoroutine()
    {
        float rndmTime = 50f;
        //random number between 20 and 50

        for (float f = rndmTime; f >= 0; f -= 1f)
        {
            Bomb.transform.Translate(shake, 0, 0);
            shake = shake * -1;
            yield return new WaitForSeconds(0.05f);
        }

        LevelManager.instance.Explode();
    }
}
