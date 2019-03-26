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
        Player _player;
        public int minutes;
        public float seconds;
        public float currentFadeTime;
        bool timed = false;


        // Start is called before the first frame update
        void Start()
        {
            _player = GameObject.Find("Player").GetComponent<Player>();
            timeRest.text = minutes.ToString() + " : " + Math.Floor(seconds).ToString();
        }

        // Update is called once per frame
        void Update()
        {
            //print("Pause         " + _player.paused);
            //print("Play         " + _player.start);
            if (minutes >= 0 && Math.Floor(seconds) != 0)
            {
                if (!_player.paused && _player.start)
                    {
                        seconds -= Time.deltaTime;
                    }
                if (seconds <= 0 && minutes > 0)
                {
                    minutes--;
                    seconds = 59;
                }
                timeRest.text = minutes.ToString() + " : " + Math.Floor(seconds).ToString();
            }
                else if (minutes <= 0 && Math.Floor(seconds) == 0)
                {
                    SteamVR_Fade.Start(Color.black, currentFadeTime);
                    StartCoroutine(ExecuteAfterTime());

                }
            
        }

        IEnumerator ExecuteAfterTime()
        {
            yield return new WaitForSeconds(3.5f);
            SceneManager.LoadScene("MainMenu");
        }

    }
}