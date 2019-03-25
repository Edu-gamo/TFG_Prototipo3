using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Valve.VR.InteractionSystem
{
    public class USB : MonoBehaviour
    {
        public GameObject _usb;
        public GameObject _usbIN;
        public FinalButton _finalButton;
        public AudioSource _audio;
        // Start is called before the first frame update
        void Start()
        {
            _usbIN.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {

        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.name == "USB")
            {
                _usbIN.SetActive(true);
                _usb.SetActive(false);
                _finalButton.energy = true;
                _audio.Play();
            }
        }
    }
}
