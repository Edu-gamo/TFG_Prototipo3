using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPanelController : MonoBehaviour {

    public Valve.VR.InteractionSystem.HoverButton hB0, hB1, hB2, hB3, hB4, hB5, hB6, hB7, hB8, hB9;

    // Use this for initialization
    void Start () {

        hB0.onButtonDown.AddListener(HoverButton0);
        hB1.onButtonDown.AddListener(HoverButton1);
        hB2.onButtonDown.AddListener(HoverButton2);
        hB3.onButtonDown.AddListener(HoverButton3);
        hB4.onButtonDown.AddListener(HoverButton4);
        hB5.onButtonDown.AddListener(HoverButton5);
        hB6.onButtonDown.AddListener(HoverButton6);
        hB7.onButtonDown.AddListener(HoverButton7);
        hB8.onButtonDown.AddListener(HoverButton8);
        hB9.onButtonDown.AddListener(HoverButton9);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void HoverButton0(Valve.VR.InteractionSystem.Hand hand) { Button0(); }
    private void HoverButton1(Valve.VR.InteractionSystem.Hand hand) { Button1(); }
    private void HoverButton2(Valve.VR.InteractionSystem.Hand hand) { Button2(); }
    private void HoverButton3(Valve.VR.InteractionSystem.Hand hand) { Button3(); }
    private void HoverButton4(Valve.VR.InteractionSystem.Hand hand) { Button4(); }
    private void HoverButton5(Valve.VR.InteractionSystem.Hand hand) { Button5(); }
    private void HoverButton6(Valve.VR.InteractionSystem.Hand hand) { Button6(); }
    private void HoverButton7(Valve.VR.InteractionSystem.Hand hand) { Button7(); }
    private void HoverButton8(Valve.VR.InteractionSystem.Hand hand) { Button8(); }
    private void HoverButton9(Valve.VR.InteractionSystem.Hand hand) { Button9(); }

    public void Button0() { Debug.Log("0"); }
    public void Button1() { Debug.Log("1"); }
    public void Button2() { Debug.Log("2"); }
    public void Button3() { Debug.Log("3"); }
    public void Button4() { Debug.Log("4"); }
    public void Button5() { Debug.Log("5"); }
    public void Button6() { Debug.Log("6"); }
    public void Button7() { Debug.Log("7"); }
    public void Button8() { Debug.Log("8"); }
    public void Button9() { Debug.Log("9"); }

}
