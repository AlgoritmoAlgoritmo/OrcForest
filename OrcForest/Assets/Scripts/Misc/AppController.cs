/*
* Author: irisGameDev
* GitHub: https://github.com/irisGameDev
* Date: 18/10/2024 (DD/MM/YYYY)
*/


using UnityEngine;
using UnityEngine.SceneManagement;


namespace OrcForest.Misc {
	public class AppController : MonoBehaviour {
		#region Variables
		#endregion

		#region Public methods
		public void LoadScene( string _sceneName ) {
			SceneManager.LoadScene( _sceneName );
		}

		public void ReloadScene() {
			SceneManager.LoadScene( 0 );
		}
		#endregion    
	}
}