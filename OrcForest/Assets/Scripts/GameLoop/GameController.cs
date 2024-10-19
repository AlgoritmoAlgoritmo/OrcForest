/*
* Author: irisGameDev
* GitHub: https://github.com/irisGameDev
* Date: 17/10/2024 (DD/MM/YYYY)
*/


using UnityEngine;
using UnityEngine.Events;
using OrcForest.Enemies;
using OrcForest.Player;


namespace OrcForest.GameLoop {
	public class GameController : MonoBehaviour {
		#region Variables
		public UnityEvent OnGameOver;
		#endregion


		#region Public methods
		public void EnemyDamaged( GameObject _enemyObject, int _damageAmount ) {
			if( !_enemyObject.GetComponent<EnemyFacade>().ReceiveDamage( _damageAmount ) ) {
				_enemyObject.GetComponent<EnemyFacade>().Destroy();
			}
		}

		public void PlayerDamaged( GameObject _playerObject, int _damageAmount ) {
			if( !_playerObject.GetComponent<PlayerFacade>().ReceiveDamage( _damageAmount ) ) {
				GameOver();
			}
		}

		public void InstantiateEnemy( GameObject _gameObject ) {
			Instantiate(_gameObject).GetComponent<EnemyFacade>()
							.OnPlayerDamaged.AddListener(PlayerDamaged);
		}

		public void PauseGame() {
			Time.timeScale = 0;
		}

		public void ResumeGame() {
			Time.timeScale = 1;
		}
		#endregion


		#region Private methods
		private void GameOver() {
			OnGameOver.Invoke();
			PauseGame();
		}
		#endregion
	}
}