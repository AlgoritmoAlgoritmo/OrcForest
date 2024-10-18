/*
* Author: irisGameDev
* GitHub: https://github.com/irisGameDev
* Date: 18/10/2024 (DD/MM/YYYY)
*/


using UnityEngine;


namespace OrcForest.Misc {
	[System.Serializable]
	public class HPController {
		#region Variables
		[SerializeField]
		protected int maxHP;

		protected int currentHP = 0;
		#endregion

		#region Public methods
		public void Initialize() {
			currentHP = maxHP;
		}

		public virtual bool DealDamage( int _damageAmount ) {
			currentHP -= _damageAmount;

			return currentHP > 0;
		}
		#endregion
	}
}