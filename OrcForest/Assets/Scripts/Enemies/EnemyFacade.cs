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

        [Header( "Misc variables" )]
        [SerializeField]
        private Misc.HPController hpController;
        #endregion


        #region MonoBehaviour methods
        private void Awake() {
            weaponsArray = GetComponentsInChildren<AbstractWeapon>(true);

            foreach( var auxWeapon in weaponsArray ) {
                auxWeapon.OnDamageDealt.AddListener( DamagePlayer );
            }

            hpController.Initialize();
        }
        #endregion


        #region Public methods
        public bool ReceiveDamage( int _damage ) {
            return hpController.DealDamage( _damage );
        }

        public void Destroy() {
            Destroy(gameObject);
        }
        #endregion


        #region Private methods
        private void DamagePlayer( GameObject _playerObject, int _damage ) {
            OnPlayerDamaged.Invoke( _playerObject, _damage );
        }
        #endregion
    }
}