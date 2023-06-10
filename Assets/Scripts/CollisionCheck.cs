using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    private float points;

    void Start()
    {

    }

    void Update()
    {

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
                print("Your score in seconds: " + Time.time);
            }
        }
    }
}
