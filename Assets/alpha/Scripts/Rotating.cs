//======= Copyright (c) Valve Corporation, All rights reserved. ===============

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

namespace Valve.VR.InteractionSystem.Sample
{
    public class Rotating : MonoBehaviour
    {
        public SteamVR_Action_Boolean plantAction;
        public SteamVR_Action_Vector2.AxisHandler rotateAction;

        public Hand hand;
        
        private void OnEnable()
        {
            if (hand == null)
                hand = this.GetComponent<Hand>();

            if (plantAction == null)
            {
                Debug.LogError("<b>[SteamVR Interaction]</b> No plant action assigned");
                return;
            }
            //rotateAction.AddOnAxisListener(OnPlantActionChange, hand.handType);
            //rotateAction.AddOnChangeListener(OnPlantActionChange, hand.handType);
            //plantAction.AddOnChangeListener(OnPlantActionChange, hand.handType);
        }
        private void OnDisable()
        {
            if (plantAction != null)
                plantAction.RemoveOnChangeListener(OnPlantActionChange, hand.handType);
        }

        private void OnPlantActionChange(SteamVR_Action_Boolean actionIn, SteamVR_Input_Sources inputSource, bool newValue)
        {
            if (newValue)
            {
                Plant();
            }
        }

        public void Plant()
        {
            StartCoroutine(DoRotate());
        }

        private IEnumerator DoRotate()
        {
            return null;
        }
    }
}