/*
* Author: irisGameDev
* GitHub: https://github.com/irisGameDev
* Date: 17/10/2024 (DD/MM/YYYY)
*/


using OrcForest.Enemies;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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
			Debug.Log( "Player damaged" );
		}
		#endregion
	}
}