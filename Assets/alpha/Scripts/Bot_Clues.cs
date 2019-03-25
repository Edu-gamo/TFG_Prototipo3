using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Valve.VR.InteractionSystem
{
    public class Bot_Clues : MonoBehaviour
    {
        public AudioSource[] _clues;
        public Player _player;
        int newLevel;
        bool given = false;
        // Start is called before the first frame update
        void Start()
        {
            print(_clues[0].clip.length);
        }

        // Update is called once per frame
        void Update()
        {
            //print(given);
            if (_player.level != newLevel)
            {
                newLevel =  _player.level;
                given = false;
            }

            if (!given)
            {
                switch (_player.level)
                {
                    case 0:

                        _clues[_player.level].Play();
                        given = true;
                        StartCoroutine(ExecuteAfterTime());
                        
                        break;

                    case 1:
                        print("Holi");
                       // _clues[1].Play();
                        //given = true;
                        //StartCoroutine(ExecuteAfterTime());

                        break;

                }
            }
            
        }

        IEnumerator ExecuteAfterTime()
        {
            yield return new WaitForSeconds(_clues[_player.level].clip.length);
            //_player.level++;    
        }
    }
}
