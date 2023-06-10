using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildCheck : MonoBehaviour
{

    void Update()
    {
        checkIfChildExists();
    }

    void checkIfChildExists()
    {
        if(transform.childCount == 0)
        {
            Time.timeScale = 0;
        }
    }
}
