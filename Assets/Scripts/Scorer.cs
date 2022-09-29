using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hitCount;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Hit")
        {
            playerHitWall();
        }    
    }
    void playerHitWall()
    {
        hitCount++;
        Debug.Log("You have bumped into a thing this many times: " + hitCount);
    }
}

