/*
* Author: irisGameDev
* GitHub: https://github.com/irisGameDev
* Date: 17/10/2024 (DD/MM/YYYY)
*/


using UnityEngine;


namespace OrcForest.Misc {
	[System.Serializable]
	public class RigidBody2DMovement {
		#region Variables
		[SerializeField]
		private float speed = 1f;
		[SerializeField]
		private Rigidbody2D rigidBody2D;
		#endregion

		#region Public methods
		public void Move( Vector2 _direction ) {
			rigidBody2D.MovePosition( rigidBody2D.position + _direction * speed );
		}
		#endregion
	}
}