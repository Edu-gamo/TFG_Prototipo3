using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExitButton : MonoBehaviour
{

    public Valve.VR.InteractionSystem.HoverButton exitButton;


    // Use this for initialization
    void Start()
    {
        exitButton.onButtonDown.AddListener(OnButtonDown);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnButtonDown(Valve.VR.InteractionSystem.Hand hand)
    {
        Application.Quit();

    }
}