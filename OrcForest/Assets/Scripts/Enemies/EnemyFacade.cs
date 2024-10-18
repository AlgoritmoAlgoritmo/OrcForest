/*
* Author: irisGameDev
* GitHub: https://github.com/irisGameDev
* Date: 18/10/2024 (DD/MM/YYYY)
*/


using UnityEngine;
using OrcForest.Weapons.Abstract;


namespace OrcForest.Enemies {
	public class EnemyFacade : MonoBehaviour {
        #region Variables
        [Header( "Weapon variables" )]
        public Weapons.DamageDealtEvent OnPlayerDamaged;

		private AbstractWeapon[] weaponsArray;
        #endregion


        #region MonoBehaviour methods
        private void Awake() {
            weaponsArray = GetComponentsInChildren<AbstractWeapon>();

            foreach( var auxWeapon in weaponsArray ) {
                auxWeapon.OnDamageDealt.AddListener( DamagePlayer );
            }
        }
        #endregion


        #region Public methods
        #endregion


        #region Private methods
        private void DamagePlayer( GameObject _playerObject, int _damage ) {
            OnPlayerDamaged.Invoke( _playerObject, _damage );
        }
        #endregion
    }
}