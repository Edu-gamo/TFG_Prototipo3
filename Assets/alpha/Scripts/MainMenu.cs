using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Valve.VR.InteractionSystem
{
    public class MainMenu : MonoBehaviour
    {
        public Player _player;
        SteamVR_LoadLevel loader;

        public float currentFadeTime = 2.5f;

        public void StartGame()
        {
            loader.
            SteamVR_Fade.Start(Color.black, currentFadeTime);
            Destroy(_player);
            StartCoroutine(ExecuteAfterTime());
        }
        public void ExitGame()
        {
            Application.Quit();
        }

        public void CreditsScreen()
        {
            Application.Quit();
        }

        public void BackMenu()
        {
            Application.Quit();
        }

        IEnumerator ExecuteAfterTime()
        {
            yield return new WaitForSeconds(2.5f);
            SceneManager.LoadScene("AdriTest");
        }
    }    
}
