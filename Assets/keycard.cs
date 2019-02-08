using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keycard : MonoBehaviour {
    public bool opened;
   
    float endPos = 10;
    float speed = 5f;
    // Use this for initialization
    void Start () {
        opened = false;       
	}
	
	// Update is called once per frame
	void Update () {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "KeyCard") // Detectem que passem la keycard
        {
            Debug.Log(other.name + "has opened the door");
            opened = true; //Obrim porta
        }
        else if (other.name == "KeyCard2") // Detectem que passem la keycard
        {
            Debug.Log(other.name + "load level");
            Application.LoadLevel("AlphaTEST");
        }
        else if (other.name == "KeyCard3") // Detectem que passem la keycard
        {
            Debug.Log(other.name + "close game");
            Application.Quit();
        }
        else if (other.name == "KeyCard3") // Detectem que passem la keycard
        {
            Debug.Log(other.name + "close game");
            Application.Quit();
        }
        else if (other.name == "KeyCard4") // Detectem que passem la keycard
        {
            Debug.Log(other.name + "option menu");
            
        }
        else  //Si no es la keycard no s'obre
        {
            Debug.Log(other.name + "useless");
        }
    }
}
