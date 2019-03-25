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
            newRot = new Vector3(this.transform.rotation.x, cylinder.transform.rotation.y, this.transform.rotation.z);
            this.transform.rotation = cylinder.transform.rotation;
            //this.transform.eulerAngles = newRot;
        }

        private void OnTriggerEnter(Collider other)
        {
            GameObject.Find("Player").GetComponent<Player>().level++;
            scored = true;
        }
    }
}
