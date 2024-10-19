/*
* Author: irisGameDev
* GitHub: https://github.com/irisGameDev
* Date: 17/10/2024 (DD/MM/YYYY)
*/


using UnityEngine;


namespace OrcForest.Weapons {
    public class ParticleWeapon : Abstract.AbstractWeapon {
        #region Variables
        [SerializeField]
        private int damage;

        [SerializeField]
        private ParticleSystem weaponParticleSystem;
        [SerializeField]
        private string bulletBoundLayer = "BulletBound";
        #endregion


        #region MonoBehaviour methods
        private void OnParticleCollision( GameObject _detectedObject ) {
            if( _detectedObject.layer != LayerMask.NameToLayer( bulletBoundLayer ) ) {
				OnDamageDealt.Invoke( _detectedObject, damage );
			}
        }
        #endregion


        #region Public methods
        public override void Shoot() {
            if( !weaponParticleSystem.isEmitting )
                weaponParticleSystem.Play();
        }

        public override void StopShooting() {
            if( weaponParticleSystem.isPlaying )
                weaponParticleSystem.Stop( false );
        }
        #endregion
    }
}