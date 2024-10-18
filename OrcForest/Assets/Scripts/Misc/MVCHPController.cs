/*
* Author: irisGameDev
* GitHub: https://github.com/irisGameDev
* Date: 18/10/2024 (DD/MM/YYYY)
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace OrcForest.Misc {
	[System.Serializable]
	public class MVCHPController : HPController {
		#region Variables
		[SerializeField]
		private Image hpBarImage;
		#endregion

		#region Public methods
		public override bool DealDamage( int _damageAmount ) {
			currentHP -= _damageAmount;
			UpdateView();

			return currentHP > 0;
		}
		#endregion


		#region Private methods
		protected virtual void UpdateView() {
			hpBarImage.fillAmount = (float)currentHP / (float)maxHP;
		}
		#endregion
	}
}