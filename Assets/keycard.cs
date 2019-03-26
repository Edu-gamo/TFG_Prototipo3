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
        public float endPos;
        public float speed = 0.5f;
        bool endMove = false;
        public float currentFadeTime;
        bool scored = false;
        bool scored2 = false;

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
                    door[0].transform.Translate(speed * Time.deltaTime, 0, 0);
                    door[1].transform.Translate(-speed * Time.deltaTime, 0, 0);
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
                opened = true;
                if (!scored2)
                {
                    GameObject.Find("Player").GetComponent<Player>().level++;
                    scored2 = true;
                }

            }
            else  //Si no es la keycard no s'obre
            {
            }
        }

        IEnumerator ExecuteAfterTime()
        {
            yield return new WaitForSeconds(2.5f);
            SceneManager.LoadScene("AdriTest");
        }
    }
}
