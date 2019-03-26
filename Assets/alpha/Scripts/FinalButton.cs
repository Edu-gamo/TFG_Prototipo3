using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem
{
    public class FinalButton : MonoBehaviour
    {
        public Valve.VR.InteractionSystem.HoverButton button;
        public GameObject[] door;
        public GameObject[] protector;
        bool pressed = false;
        public float endPos;
        public float speed = 0.5f;
        bool endMove = false;
        bool activated = false;
        public bool energy = false;
        // Start is called before the first frame update
        void Start()
        {
            protector[0].SetActive(false);
            button.onButtonDown.AddListener(OnButtonDown);
        }

        // Update is called once per frame
        void Update()
        {
            if (!activated && energy)
            {
                GameObject.Find("Player").GetComponent<Player>().level++;
                protector[0].SetActive(true);
                protector[1].SetActive(false);
                activated = true;
            }

            if (pressed)
            {
                for (int i = 0; i < door.Length; i++)
                {
                    if (!endMove) // comencem a obrir la porta
                    {
                        door[0].transform.Translate(speed * Time.deltaTime, 0, 0);
                        door[1].transform.Translate(-speed * Time.deltaTime, 0, 0);
                    }

                    if (door[i].transform.position.x > endPos) // Quan la porta arriva al final posem el bool
                    {
                        endMove = true;
                    }
                }
            }
        }

        private void OnButtonDown(Valve.VR.InteractionSystem.Hand hand)
        {
            if (energy)
            {
                pressed = true;
                print("hii");
            }
        }
    }
}