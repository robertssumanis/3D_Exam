using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public Text timer;

    void Start()
    {
        
    }

    void Update()
    {
        timer.text = "" + Time.time.ToString("F3") + "";
    }
}
