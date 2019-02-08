using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonPanel : MonoBehaviour
{

    public Valve.VR.InteractionSystem.HoverButton[] buttons;
    public Text screenText;
    public float restTime;
    public float t;
    bool timed = false;


    // Use this for initialization
    void Start()
    {

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].onButtonDown.AddListener(OnButtonDown);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (screenText.text.Length >= 4 && !timed)
        {
            if (screenText.text == "1234")
            {
                Debug.Log("GG");
            }
            else
            {
                t = Time.time;
                timed = true;
                Debug.Log(t);
            }
        }

        if(timed && t + restTime < Time.time)
        {
            screenText.text = "";
            timed = false;
        }
    }

    private void OnButtonDown(Valve.VR.InteractionSystem.Hand hand)
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            if (buttons[i].buttonDown)
            {
                if(buttons[i].name == "Button0")
                {
                    screenText.text += "0";
                }
                else if (buttons[i].name == "Button1")
                {
                    screenText.text += "1";
                }
                else if (buttons[i].name == "Button2")
                {
                    screenText.text += "2";
                }
                else if (buttons[i].name == "Button3")
                {
                    screenText.text += "3";
                }
                else if (buttons[i].name == "Button4")
                {
                    screenText.text += "4";
                }
                else if (buttons[i].name == "Button5")
                {
                    screenText.text += "5";
                }
                else if (buttons[i].name == "Button6")
                {
                    screenText.text += "6";
                }
                else if (buttons[i].name == "Button7")
                {
                    screenText.text += "7";
                }
                else if (buttons[i].name == "Button8")
                {
                    screenText.text += "8";
                }
                else if (buttons[i].name == "Button9")
                {
                    screenText.text += "9";
                }
            }

        }        
    }
}