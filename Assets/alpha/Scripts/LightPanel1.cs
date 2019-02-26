using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LightPanel1 : MonoBehaviour
{

    public Valve.VR.InteractionSystem.HoverButton[] buttons;
    public GameObject[] lights;
    public bool[] opened;
    public Material[] materials;
    bool solved = false;


    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].onButtonDown.AddListener(OnButtonDown);
        }
        for (int i = 0; i < opened.Length; i++)
        {
            opened[i] = false;
        }
        opened[1] = true;
        opened[2] = true;
        for (int i = 0; i < opened.Length; i++)
        {
            if (opened[i])
            {
                lights[i].GetComponent<Renderer>().material = materials[1];
            }
            else
            {
                lights[i].GetComponent<Renderer>().material = materials[0];
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnButtonDown(Valve.VR.InteractionSystem.Hand hand)
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            if (buttons[i].buttonDown)
            {

                if (buttons[i].name == "Button1")
                {
                    //Debug.Log(i);
                    //Debug.Log(buttons[i].name);
                    if (opened[i])
                    {
                        opened[i] = false;
                    }
                    else
                    {
                        opened[i] = true;
                    }
                }
                else if (buttons[i].name == "Button2")
                {
                    //Debug.Log(i);
                    //Debug.Log(buttons[i].name);
                    if (opened[i])
                    {
                        opened[i] = false;
                    }
                    else
                    {
                        opened[i] = true;
                    }
                }
                else if (buttons[i].name == "Button3")
                {
                    //Debug.Log(i);
                    //Debug.Log(buttons[i].name);
                    if (opened[i])
                    {
                        opened[i] = false;
                    }
                    else
                    {
                        opened[i] = true;
                    }
                }
                else if (buttons[i].name == "Button4")  //3
                {
                    //Debug.Log(i);
                    //Debug.Log(buttons[i].name);
                    if (opened[i])
                    {
                        opened[i] = false;
                    }
                    else
                    {
                        opened[i] = true;
                    }
                }
                else if (buttons[i].name == "Button5")
                {
                    //Debug.Log(i);
                    //Debug.Log(buttons[i].name);
                    if (opened[i])
                    {
                        opened[i] = false;
                    }
                    else
                    {
                        opened[i] = true;
                    }
                }
            }
        }
        for (int i = 0; i < opened.Length; i++)
        {
            if (opened[i] == true)
            {
                //if (i == 0)
                //{
                //    lights[1].GetComponent<Renderer>().material = materials[0];
                //}
                 if (i == lights.Length - 1)
                {
                    lights[lights.Length - 2].GetComponent<Renderer>().material = materials[0];
                }
                else
                {
                    lights[i - 1].GetComponent<Renderer>().material = materials[0];
                    lights[i + 1].GetComponent<Renderer>().material = materials[0];
                }
            }

            else
            {
                if (opened[i] == false)
                {
                    //if (i == 0)
                    //{
                    //    lights[1].GetComponent<Renderer>().material = materials[1];
                      
                    //}
                     if (i == lights.Length - 1)
                    {
                        lights[lights.Length - 2].GetComponent<Renderer>().material = materials[1];
                        //Debug.Log(i);
                    }
                    else if (i > 0 && i < lights.Length - 1)
                    {
                        lights[i - 1].GetComponent<Renderer>().material = materials[1];
                        lights[i + 1].GetComponent<Renderer>().material = materials[1];
                        Debug.Log(i);
                        Debug.Log(i+1);
                    
                        Debug.Log(i - 1);
                        Debug.Log("puto sin");
                    }
                }

            }
        }
    }
}
