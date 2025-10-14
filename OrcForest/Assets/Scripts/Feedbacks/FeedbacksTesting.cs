/*
* Author: irisGameDev
* GitHub: https://github.com/irisGameDev
* Date: 12/10/2025 (DD/MM/YYYY)
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace OrcForest.Feedbacks {
	public class FeedbacksTesting : MonoBehaviour {
		#region Properties
		public Interfaces.IFeedback feedback;
		#endregion
		
	
		#region MonoBehaviour Methods
		private void Start() {
			feedback.Initialize();
		}
		
		private void Update() {
			if( Input.GetKeyUp( KeyCode.Q ) ) {
				feedback.PlayFeedback();
			}
		}
		#endregion	
	}
}
