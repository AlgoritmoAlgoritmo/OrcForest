/*
* Author: irisGameDev
* GitHub: https://github.com/irisGameDev
* Date: 18/10/2024 (DD/MM/YYYY)
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace OrcForest.Misc {
	public class AppController : MonoBehaviour {
		#region Variables
		#endregion

		#region Public methods
		public void ReloadScene() {
			SceneManager.LoadScene( 0 );
		}
		#endregion    
	}
}