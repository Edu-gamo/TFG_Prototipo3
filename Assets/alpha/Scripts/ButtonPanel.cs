using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Valve.VR.InteractionSystem
{
    public class ButtonPanel : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.HoverButton[] buttons;
        public Text screenText;
        public float restTime;
        public float t;
        bool timed = false;
        public bool solved = false;
        public GameObject door;
        public GameObject _light;
        public Material _material;
        bool scored = false;
        public bool correct;
        public string answer = "";

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
                if (screenText.text == answer)
                {
                    solved = true;              
                    if (!scored && correct)
                    {
                        GameObject.Find("Player").GetComponent<Player>().level++;
                        scored = true;

                    }

                }
                else
                {
                    t = Time.time;
                    timed = true;
                    Debug.Log(t);
                }
            }

            if (solved)
            {
                door.GetComponent<SphereCollider>().enabled = true;
                _light.GetComponent<Renderer>().material = _material;
            }

            if (timed && t + restTime < Time.time)
            {
                screenText.text = "";
                timed = false;
            }
        }

        private void OnButtonDown(Valve.VR.InteractionSystem.Hand hand)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                if (buttons[i].buttonDown && !solved && screenText.text.Length < 4)
                {
                    int temp = i + 1;
                    if (temp == 10) temp = 0;
                    screenText.text += temp;
                }
            }
        }
    }
}