using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem
{
    [System.Serializable] 
    public struct LightObject
    {
        public Valve.VR.InteractionSystem.HoverButton button;
        public GameObject _light;
        public bool opened;
    }
    public class LightPanel : MonoBehaviour
    {

        public LightObject[] lightList;
        public Material[] materials;
        int openedCount = 2;
        bool scored = false;


        // Use this for initialization
        void Start()
        {
            for (int i = 0; i < lightList.Length; i++)
            {
                lightList[i].button.onButtonDown.AddListener(OnButtonDown);
            }
            for (int i = 0; i < lightList.Length; i++)
            {
                lightList[i].opened = false;
            }
            lightList[1].opened = true;
            lightList[3].opened = true;
        }

        // Update is called once per frame
        void Update()
        {
            if (GameObject.Find("Player").GetComponent<Player>().level == 7)
            {
                if (openedCount == 5 && !scored)
                {
                    GameObject.Find("Player").GetComponent<Player>().level++;
                    scored = true;
                }

                for (int i = 0; i < lightList.Length; i++)
                {
                    if (lightList[i].opened)
                    {
                        lightList[i]._light.GetComponent<Renderer>().material = materials[1];
                    }
                    else
                    {
                        lightList[i]._light.GetComponent<Renderer>().material = materials[0];
                    }

                }
            }
            

        }

        private void OnButtonDown(Valve.VR.InteractionSystem.Hand hand)
        {
            if (openedCount < 5)
            {

                for (int i = 0; i < lightList.Length; i++)
                {
                    if (lightList[i].button.buttonDown)
                    {

                        if (lightList[i].button.name == "Button1") //0
                        {
                            if (lightList[i + 1].opened)
                            {
                                lightList[i + 1].opened = false;
                                openedCount--;
                            }
                            else
                            {
                                lightList[i + 1].opened = true;
                                openedCount++;
                            }
                            if (lightList[i].opened)
                            {
                                lightList[i].opened = false;
                                openedCount--;
                            }
                            else
                            {
                                lightList[i].opened = true;
                                openedCount++;
                            }
                        }
                        else if (lightList[i].button.name == "Button5") //4
                        {
                            if (lightList[lightList.Length - 2].opened)
                            {
                                lightList[lightList.Length - 2].opened = false;
                                openedCount--;
                            }
                            else
                            {
                                lightList[lightList.Length - 2].opened = true;
                                openedCount++;
                            }
                            if (lightList[i].opened)
                            {
                                lightList[i].opened = false;
                                openedCount--;
                            }
                            else
                            {
                                lightList[i].opened = true;
                                openedCount++;
                            }
                        }
                        else
                        {
                            if (lightList[i + 1].opened)
                            {
                                lightList[i + 1].opened = false;
                                openedCount--;
                            }
                            else
                            {
                                lightList[i + 1].opened = true;
                                openedCount++;
                            }

                            if (lightList[i - 1].opened)
                            {
                                lightList[i - 1].opened = false;
                                openedCount--;
                            }
                            else
                            {
                                lightList[i - 1].opened = true;
                                openedCount++;
                            }
                            if (lightList[i].opened)
                            {
                                lightList[i].opened = false;
                                openedCount--;
                            }
                            else
                            {
                                lightList[i].opened = true;
                                openedCount++;
                            }
                        }
                    }
                }
            }
        }
    }
}