using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    private float points;
    public float playedTime;

    void Start()
    {
        playedTime = 0;
    }

    void Update(){
    
        playedTime += Time.deltaTime;

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player") 
        {
            Debug.Log("+1 point");
            Destroy(gameObject);
            points = points + 1;
            print(points);
            if (points == 4){
                print("Your score in seconds: " + playedTime);
            }
        }
    }
}
