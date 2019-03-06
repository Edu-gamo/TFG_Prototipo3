using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem
{

    public class LightPanel : MonoBehaviour
    {

        public Valve.VR.InteractionSystem.HoverButton[] buttons;
        public GameObject[] lights;
        public bool[] opened;
        public Material[] materials;
        int openedCount = 2;
        bool scored = false;


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
            opened[3] = true;

        }

        // Update is called once per frame
        void Update()
        {
            
            if (openedCount == 5 && !scored)
            {
                GameObject.Find("Player").GetComponent<Player>().level++;
                scored = true;
            }

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
            if (openedCount < 5)
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
                                openedCount--;
                            }
                            else
                            {
                                opened[i + 1] = true;
                                openedCount++;
                            }
                            if (opened[i])
                            {
                                opened[i] = false;
                                openedCount--;
                            }
                            else
                            {
                                opened[i] = true;
                                openedCount++;
                            }
                        }
                        else if (buttons[i].name == "Button5") //4
                        {
                            if (opened[lights.Length - 2])
                            {
                                opened[lights.Length - 2] = false;
                                openedCount--;
                            }
                            else
                            {
                                opened[lights.Length - 2] = true;
                                openedCount++;
                            }
                            if (opened[i])
                            {
                                opened[i] = false;
                                openedCount--;
                            }
                            else
                            {
                                opened[i] = true;
                                openedCount++;
                            }
                        }
                        else
                        {
                            if (opened[i + 1])
                            {
                                opened[i + 1] = false;
                                openedCount--;
                            }
                            else
                            {
                                opened[i + 1] = true;
                                openedCount++;
                            }

                            if (opened[i - 1])
                            {
                                opened[i - 1] = false;
                                openedCount--;
                            }
                            else
                            {
                                opened[i - 1] = true;
                                openedCount++;
                            }
                            if (opened[i])
                            {
                                opened[i] = false;
                                openedCount--;
                            }
                            else
                            {
                                opened[i] = true;
                                openedCount++;
                            }
                        }
                    }
                }
            }
        }
    }
}