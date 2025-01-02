/*
* Author: irisGameDev
* GitHub: https://github.com/irisGameDev
* Date: 19/10/2024 (DD/MM/YYYY)
*/


using UnityEngine;


namespace OrcForest.Misc {
	public class LookAtScript : MonoBehaviour {
		#region Variables
		[SerializeField]
		private Transform target;
		[SerializeField]
		private Transform[] transformsToRotate;
		[SerializeField]
		private bool isTrackingTarget = true;
		#endregion


		#region MonoBehaviour methods
		private void FixedUpdate() {
			if( isTrackingTarget )
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