/*
* Author: irisGameDev
* GitHub: https://github.com/irisGameDev
* Date: 17/10/2024 (DD/MM/YYYY)
*/


using UnityEngine;
using UnityEngine.InputSystem;
using OrcForest.Misc;
using OrcForest.Weapons.Abstract;


namespace OrcForest.Player {
	public class PlayerFacade : MonoBehaviour {
		#region Variables
        [Header("Movement Variables")]
        [SerializeField]
        private RigidBody2DMovement rigidBodyMovement;
        [SerializeField]
        private string moveActionName = "Move";

        [Header( "Weapon Variables" )]
        [SerializeField]
        private string shootActionName = "Shoot";
        [SerializeField]
        private AbstractWeapon weapon;

        [Header("Misc Variables")]
		[SerializeField]
		private PlayerInput playerInput;
        #endregion

        #region MonoBehaviour methods
        private void Awake() {
            if( !playerInput )
                playerInput = FindObjectOfType<PlayerInput>();
        }


        private void FixedUpdate() {
            ReadPlayerInput();
        }
        #endregion

        #region Public methods
        #endregion

        #region Private methods
        private void ReadPlayerInput() {
            rigidBodyMovement.Move( playerInput.actions[moveActionName].ReadValue<Vector2>() );

            if( playerInput.actions[shootActionName].IsPressed() ) {
                weapon.Shoot();

            } else {
                weapon.StopShooting();
            }
        }
        #endregion
    }
}