/*
* Author: irisGameDev
* GitHub: https://github.com/irisGameDev
* Date: 19/10/2024 (DD/MM/YYYY)
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace OrcForest.Misc {
	public class LookAtScript : MonoBehaviour {
		#region Variables
		[SerializeField]
		private Transform target;
		[SerializeField]
		private Transform[] transformsToRotate;
		#endregion


		#region MonoBehaviour methods
		private void FixedUpdate() {
			UpdateTargetsRotation();
		}
		#endregion
		
		
		#region Private methods
		private void UpdateTargetsRotation () {
			foreach( var auxTransform in transformsToRotate ) {
				auxTransform.LookAt( target );
			}
		}
		#endregion
	}
}