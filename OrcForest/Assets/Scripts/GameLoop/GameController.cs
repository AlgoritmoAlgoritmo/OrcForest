/*
* Author: irisGameDev
* GitHub: https://github.com/irisGameDev
* Date: 17/10/2024 (DD/MM/YYYY)
*/


using UnityEngine;
using OrcForest.Enemies;
using OrcForest.Player;


namespace OrcForest.GameLoop {
	public class GameController : MonoBehaviour {
		#region Variables
		#endregion

		#region Public methods
		public void EnemyDamaged( GameObject _enemyObject, int _damageAmount ) {
			Debug.Log("Enemy damaged");
			if( !_enemyObject.GetComponent<EnemyFacade>().ReceiveDamage( _damageAmount ) ) {
				Debug.Log( "Enemy killed" );
			}
		}

		public void PlayerDamaged( GameObject _playerObject, int _damageAmount ) {
			Debug.Log( "Player damaged: " + _damageAmount );
			if( !_playerObject.GetComponent<PlayerFacade>().ReceiveDamage( _damageAmount ) ) {
				Debug.Log( "Player killed" );
			}
		}
		#endregion
	}
}