/*
* Author: irisGameDev
* GitHub: https://github.com/irisGameDev
* Date: 17/10/2024 (DD/MM/YYYY)
*/


namespace OrcForest.Weapons {
	[System.Serializable]
	public class DamageDealtEvent : UnityEngine.Events.UnityEvent<
									UnityEngine.GameObject, int> { }
}