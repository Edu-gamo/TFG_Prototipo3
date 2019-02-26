using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class Crono : MonoBehaviour
{
    public Text timeRest;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timeRest.text = string.Format("{0}:{1}", DateTime.Now.Hour, DateTime.Now.Minute);
        transform.LookAt(Camera.main.transform);
    }
}
