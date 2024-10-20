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
        [SerializeField]
        private AbstractWeapon[] weaponsArray;

        [Header( "Misc variables" )]
        [SerializeField]
        private Misc.MVCHPController hpController;
        #endregion


        #region MonoBehaviour methods
        private void Awake() {
			if( weaponsArray == null || weaponsArray.Length == 0 ) {
				weaponsArray = GetComponentsInChildren<AbstractWeapon>(true);
			}
			
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

        public void Shoot() {
            foreach( var auxWeapon in weaponsArray ) {
                auxWeapon.Shoot();
            }
        }

        public void StopShooting() {
            foreach( var auxWeapon in weaponsArray ) {
                auxWeapon.StopShooting();
            }
        }
        #endregion


        #region Private methods
        private void DamagePlayer( GameObject _playerObject, int _damage ) {
            OnPlayerDamaged.Invoke( _playerObject, _damage );
        }
        #endregion
    }
}