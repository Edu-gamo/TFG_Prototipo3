using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


namespace Valve.VR.InteractionSystem
{
    public class Crono : MonoBehaviour
    {
        public Text timeRest;
        public Transform target;
        public int minutes;
        float seconds = 59;
        public int currentFadeTime;


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            seconds -= Time.deltaTime;
            if (minutes > 0)
            {
                if (seconds < 0)
                {
                    minutes--;
                    seconds = 59;
                }
                //.text = minutes + " : " + Math.Floor(seconds);
            }
            else
            {
                //SteamVR_Fade.Start(Color.clear, 0);
                //SteamVR_Fade.Start(Color.black, currentFadeTime);

                //SceneManager.LoadScene("FinalScene");
                //SteamVR_Fade.Start(Color.clear, currentFadeTime);
                //timeRest.text = "Time out!";
               
            }


        }
    }
}