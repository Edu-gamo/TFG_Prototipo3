using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour {
    public keycard doorScript;
    bool endMove;
    public float endPos;
    public float speed;
    bool opened;

    // Use this for initialization
    void Start () {
        endMove = false;
        opened = gameObject.GetComponent<keycard>();
     
    }
    
    // Update is called once per frame
    void Update () {
        opened = GameObject.Find("keycardLector").GetComponent<keycard>().opened;
        //Debug.Log(opened);
           
        if (opened && !endMove)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (transform.position.x == endPos) // Quan la porta arriva al final posem el bool
        {
            endMove = true;
        }
     
    }
}
