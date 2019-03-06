using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

namespace Valve.VR.InteractionSystem
{

    public class keycard : MonoBehaviour
    {
        public bool opened;
        public float endPos = 10;
        public float speed = 0.5f;
        bool endMove = false;
        public float currentFadeTime;
        bool scored = false;

        public GameObject[] door;
        // Use this for initialization
        void Start()
        {
            opened = false;
        }

        // Update is called once per frame
        void Update()
        {

            //obrim la porta
            for (int i = 0; i < door.Length; i++)
            {
                if (!endMove && opened) // comencem a obrir la porta
                {
                    door[i].transform.Translate(-speed * Time.deltaTime, 0, 0);
                }

                if (door[i].transform.position.x > endPos) // Quan la porta arriva al final posem el bool
                {
                    endMove = true;
                }
            }
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.name == "KeyCard") // Detectem que passem la keycard
            {
                opened = true;
                if (!scored)
                {
                    GameObject.Find("Player").GetComponent<Player>().level++;
                    scored = true;
                }

            }
            else if (other.name == "KeyCard2") // Detectem que passem la keycard
            {
                SteamVR_Fade.Start(Color.clear, 0);
                SteamVR_Fade.Start(Color.black, currentFadeTime);
                SceneManager.LoadScene("AdriTest");
                SteamVR_Fade.Start(Color.clear, currentFadeTime);
            }
            else  //Si no es la keycard no s'obre
            {
            }
        }
    }
}
