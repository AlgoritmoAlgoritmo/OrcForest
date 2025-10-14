/*
* Author: irisGameDev
* GitHub: https://github.com/irisGameDev
* Date: 13/10/2025 (DD/MM/YYYY)
*/



using UnityEditor;


namespace OrcForest.Feedbacks.Editor {
	[CustomEditor( typeof( FeedbacksTesting ) )]
	public class FeedbacksTestingInspector : UnityEditor.Editor {
        public override void OnInspectorGUI() {
            FeedbacksTesting feedbacksTesting = (FeedbacksTesting) target;

            /*
             * 
            feedbacksTesting.feedback = new EditorGUILayout.ObjectField(
                                                    "Feedback",
                                                    feedbacksTesting.feedback,
                                                    typeof( OrcForest.Feedbacks.Interfaces.IFeedback ) );
             *
            */
            /*
            var iFeedbackObjectField = new UnityEditor.UIElements.ObjectField();
            iFeedbackObjectField.objectType = typeof( Interfaces.IFeedback );
            iFeedbackObjectField.name = "Feedback";
            iFeedbackObjectField.binding = feedbacksTesting.feedback;
            */
            /*
            feedbacksTesting.feedback = new EditorGUILayout.ObjectField();
            var objectField = new ObjectField();
            objectField.objectType = typeof( Texture2D );
            objectField.label = "Select an object:";
            */

            DrawDefaultInspector();
        }
    }
}