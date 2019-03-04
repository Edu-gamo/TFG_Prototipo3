using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keycard : MonoBehaviour {
    public bool opened;
   
    public float endPos = 10;
    public float speed = 0.5f;
    bool endMove = false;

    public GameObject[] door;
    // Use this for initialization
    void Start () {
        opened = false;       
	}
	
	// Update is called once per frame
	void Update () {

        //obrim la porta
        for (int i = 0; i < door.Length; i++)
        {
            if (!endMove && opened) // comencem a obrir la porta
            {
                door[i].transform.Translate(-speed * Time.deltaTime, 0, 0);
            }

            if (door[i].transform.position.x > endPos) // Quan la porta arriva al final posem el bool
            {
                endMove = true;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "KeyCard") // Detectem que passem la keycard
        {
            opened = true;
           
        }
        else if (other.name == "KeyCard2") // Detectem que passem la keycard
        {
            SceneManager.LoadScene("AdriTest 1");  
        }
        else  //Si no es la keycard no s'obre
        {
        }
    }
}
