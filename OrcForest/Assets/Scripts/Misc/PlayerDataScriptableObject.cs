/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 09/01/2026 (DD/MM/YYYY)
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace OrcForest.Misc {
    [CreateAssetMenu(fileName= "PlayerDataScriptableObject", menuName="OrcForest/Data/PlayerData" )]
    public class PlayerDataScriptableObject : ScriptableObject {
        #region Properties
        [SerializeField]
        private bool isUsingMobileInput = false;
        public bool IsUsingMobileInput {
            get { return isUsingMobileInput; }
            set { isUsingMobileInput = value; }
        }
        #endregion
    }
}