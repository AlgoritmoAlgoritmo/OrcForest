/*
* Author: irisGameDev
* GitHub: https://github.com/irisGameDev
* Date: 19/10/2024 (DD/MM/YYYY)
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace OrcForest.Misc {
	public class ObjectInfiniteRotation : MonoBehaviour {
		#region Variables
		[SerializeField]
		private Transform target;
		[SerializeField]
		private Vector3 rotationSpeed = new Vector3( 0, 0, 0 );
		#endregion


		#region MonoBehaviour methods
		private void FixedUpdate() {
			Rotate();
		}
		#endregion


		#region Private methods
		private void Rotate() {
			target.localEulerAngles = ClampRotationEuler(
										 target.localEulerAngles + rotationSpeed );
		}


		private Vector3 ClampRotationEuler( Vector3 _rotationAngle ) {
			if( _rotationAngle.x > 360 ) {
				_rotationAngle.x -= 360;
			} else if( _rotationAngle.x < -360 ) {
				_rotationAngle.x += 360;
			}

			if( _rotationAngle.y > 360 ) {
				_rotationAngle.y -= 360;
			} else if( _rotationAngle.y < -360 ) {
				_rotationAngle.y += 360;
			}

			if( _rotationAngle.z > 360 ) {
				_rotationAngle.z -= 360;
			} else if( _rotationAngle.z < -360 ) {
				_rotationAngle.z += 360;
			}

			return _rotationAngle;
		}
		#endregion    
	}
}