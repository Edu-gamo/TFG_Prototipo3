using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;
namespace Valve.VR.InteractionSystem
{
    public class circularRotation : MonoBehaviour
    {
        public GameObject cylinder;
        Vector3 newRot;
        bool scored = false;

        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            if (GameObject.Find("Player").GetComponent<Player>().level == 6)
            {
                //  Traspasar rotació del boto a la tuberia
                newRot = new Vector3(cylinder.transform.rotation.x, cylinder.transform.localEulerAngles.z, this.transform.rotation.z);
                this.transform.localEulerAngles = newRot;


                //Comprovació de si el puzle s'ha resolt
                if (GameObject.Find("Player").GetComponent<Player>().pipeLineSolved >= 4 && !scored)
                {
                    GameObject.Find("Player").GetComponent<Player>().level++;
                    scored = true;
                }
            }
        }

        //Augmentar score
        private void OnTriggerEnter(Collider other)
        {
            GameObject.Find("Player").GetComponent<Player>().pipeLineSolved++;
        }

        //Reduir score
        private void OnTriggerExit(Collider other)
        {
            GameObject.Find("Player").GetComponent<Player>().pipeLineSolved--;
        }
    }
}
