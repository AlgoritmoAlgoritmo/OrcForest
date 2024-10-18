/*
* Author: irisGameDev
* GitHub: https://github.com/irisGameDev
* Date: 17/10/2024 (DD/MM/YYYY)
*/


using UnityEngine;


namespace OrcForest.Weapons.Abstract {
	[System.Serializable]
	public abstract class AbstractWeapon : MonoBehaviour {
		#region Variables
		public DamageDealtEvent OnDamageDealt;
        #endregion


        #region Public methods
        public abstract void Shoot();

		public abstract void StopShooting();
		#endregion
	}
}