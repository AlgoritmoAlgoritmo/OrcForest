/*
* Author: irisGameDev
* GitHub: https://github.com/irisGameDev
* Date: 18/10/2024 (DD/MM/YYYY)
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace OrcForest.Misc {
	public class InfiniteBackgroundScroller : MonoBehaviour {
		#region Variables
		[SerializeField]
		private Transform bgParent;
		[SerializeField]
		private Vector3 speed = new Vector3( 0, -.1f, 0 );
		[SerializeField]
		private Vector3 maxPosition = new Vector3( 0, -1f, 0 );

		private Vector3 originalPosition;
		#endregion

		#region MonoBehaviour methods
		private void Awake() {
			originalPosition = bgParent.position;
		}

		private void FixedUpdate() {
			bgParent.position += speed;

			if( bgParent.position.y <= maxPosition.y ) {
				bgParent.position = originalPosition;
			}
		}
		#endregion    
	}
}