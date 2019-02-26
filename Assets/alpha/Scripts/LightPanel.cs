using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LightPanel : MonoBehaviour
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
        
    }

    // Update is called once per frame
    void Update()
    {
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

    private void OnButtonDown(Valve.VR.InteractionSystem.Hand hand)
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            if (buttons[i].buttonDown)
            {

                if (buttons[i].name == "Button1") //0
                {
                    if (opened[i + 1])
                    {
                        opened[i + 1] = false;
                    }
                    else
                    {
                        opened[i + 1] = true;
                    }
                }
                //else if (buttons[i].name == "Button2") //1
                //{ 
                //    if (opened[i])
                //    {
                //        opened[i] = false;
                //    }
                //    else
                //    {
                //        opened[i] = true;
                //    }
                //}
                //else if (buttons[i].name == "Button3") //2
                //{
                //    if (opened[i])
                //    {
                //        opened[i] = false;
                //    }
                //    else
                //    {
                //        opened[i] = true;
                //    }
                //}
                //else if (buttons[i].name == "Button4")  //3
                //{
                //    if (opened[i])
                //    {
                //        opened[i] = false;
                //    }
                //    else
                //    {
                //        opened[i] = true;
                //    }
                //}
                else if (buttons[i].name == "Button5") //4
                {
                    if (opened[lights.Length - 2])
                    {
                        opened[lights.Length - 2] = false;
                    }
                    else
                    {
                        opened[lights.Length - 2] = true;
                    }
                }
                else
                {
                    if (opened[i + 1])
                    {
                        opened[i + 1] = false;
                    }
                    else 
                    {
                        opened[i + 1] = true;
                    }

                    if (opened[i - 1])
                    {
                        opened[i - 1] = false;
                    }
                     else
                    {
                        opened[i - 1] = true;
                    }
                }
            }
        }
    }
}
