using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Valve.VR.InteractionSystem
{
    public class LastRoom : MonoBehaviour
    {
        bool given = false;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        private void OnTriggerEnter(Collider other)
        {
            if (!given)
            {
                GameObject.Find("Player").GetComponent<Player>().level++;
                SteamVR_Fade.Start(Color.black, 2.5f);
                StartCoroutine(ExecuteAfterTime());
                given = true;
            }
        }
        IEnumerator ExecuteAfterTime()
        {
            yield return new WaitForSeconds(3.0f);
            SceneManager.LoadScene("MainMenu");
        }
    }
}
