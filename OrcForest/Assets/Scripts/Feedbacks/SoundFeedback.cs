/*
* Author: irisGameDev
* GitHub: https://github.com/irisGameDev
* Date: 12/10/2025 (DD/MM/YYYY)
*/


using UnityEngine;
using UnityEngine.Audio;


namespace OrcForest.Feedbacks {
    [CreateAssetMenu( fileName = "Sound Feedback ScriptableObject",
                        menuName = "OrcForest/Feedbacks/Sound Feedback")]
    public class SoundFeedback : ScriptableObject, Interfaces.IFeedback {
        #region Properties
        [SerializeField]
        private AudioClip soundFile;
        [SerializeField]
        private AudioSource audioSource;
        [SerializeField]
        private AudioMixerGroup audioMixerGroup;

        private bool isInitialized;
        #endregion


        #region Public Methods
        public void Initialize() {
            if( !isInitialized ) {
                var auxGameObject = Instantiate( new GameObject() );
                audioSource = auxGameObject.AddComponent<AudioSource>();
                audioSource.outputAudioMixerGroup = audioMixerGroup;
            }
        }

        public void PlayFeedback() {
            audioSource.clip = soundFile;
            audioSource.Play();
        }
        #endregion
    }
}