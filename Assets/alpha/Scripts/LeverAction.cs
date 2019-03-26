using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem
{
    public class LeverAction : MonoBehaviour
    {
        public AudioSource _audio;
        public Transform start, end, _lever;
        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            if (GameObject.Find("Player").GetComponent<Player>().level == 8)
            {
                if (_lever.position.y == start.position.y)
                {                                    
                    print("HI");
                    GameObject.Find("Player").GetComponent<Player>().level++;
                    _audio.Play();
                }
            }
        }
    }
}
