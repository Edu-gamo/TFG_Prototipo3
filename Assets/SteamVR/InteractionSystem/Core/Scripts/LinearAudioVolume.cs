//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Changes the pitch of this audio source based on a linear mapping
//			and a curve
//
//=============================================================================

using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	public class LinearAudioVolume : MonoBehaviour
	{
		public LinearMapping linearMapping;
		public AnimationCurve volumeCurve;
		public float minVol;
		public float maxVol;
		public bool applyContinuously = true;

		private AudioSource audioSource;

	
		//-------------------------------------------------
		void Awake()
		{
			if ( audioSource == null )
			{
				audioSource = GetComponent<AudioSource>();
			}

			if ( linearMapping == null )
			{
				linearMapping = GetComponent<LinearMapping>();
			}
		}


		//-------------------------------------------------
		void Update()
		{
			if ( applyContinuously )
			{
				Apply();
			}
		}


		//-------------------------------------------------
		private void Apply()
		{
			float y = volumeCurve.Evaluate( linearMapping.value );

			audioSource.volume = Mathf.Lerp( minVol, maxVol, y );
		}
	}
}
