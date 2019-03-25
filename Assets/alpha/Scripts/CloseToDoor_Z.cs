using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseToDoor_Z : MonoBehaviour
{
    public GameObject[] door;
    Vector3 startPos;
    public float endPos = 10;
    public float speed = 0.5f;
    bool endMove = false;
    bool open = false;
    bool close = false;
    public int type; 

    // Start is called before the first frame update
    void Start()
    {
        startPos = door[0].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //print(door[0].transform.position.z);
        //print(door[0].name);
        if (open)
        {
            for (int i = 0; i < door.Length; i++)
            {
                if (!endMove) // comencem a obrir la porta
                {
                    door[0].transform.Translate(speed * Time.deltaTime, 0, 0);
                    door[1].transform.Translate(-speed * Time.deltaTime, 0, 0);
                }

                if (type == 1)
                {
                    if (door[1].transform.position.z > endPos) // Quan la porta arriva al final posem el bool
                    {
                        endMove = true;
                    }
                }
                else if (type == 2)
                {
                    if (door[0].transform.position.z > endPos) // Quan la porta arriva al final posem el bool
                    {
                        endMove = true;
                    }
                }
                else
                {
                }
            }
        }

        if (close)
        {
            for (int i = 0; i < door.Length; i++)
            {
                if (!endMove) // comencem a obrir la porta
                {
                    door[0].transform.Translate(-speed * Time.deltaTime, 0, 0);
                    door[1].transform.Translate(speed * Time.deltaTime, 0, 0);
                }
                if (type == 1)
                {
                    if (door[1].transform.position.z < startPos.z) // Quan la porta arriva al final posem el bool
                    {
                        endMove = true;
                    }
                }
                else if (type == 2)
                {
                    if (door[0].transform.position.z < startPos.z) // Quan la porta arriva al final posem el bool
                    {
                        endMove = true;
                    }
                }
                else
                {
                }
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "BodyCollider")
        {
            open = true;
            close = false;
            endMove = false;
            print("hi");
        }
      
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "BodyCollider")
        {
            open = false;
            close = true;
            endMove = false;
            print("exit");
        }
    }
}
