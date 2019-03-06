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
        bool scored = false;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            this.transform.rotation = cylinder.transform.rotation;
        }

        private void OnTriggerEnter(Collider other)
        {
            GameObject.Find("Player").GetComponent<Player>().level++;
            scored = true;
        }
    }
}
