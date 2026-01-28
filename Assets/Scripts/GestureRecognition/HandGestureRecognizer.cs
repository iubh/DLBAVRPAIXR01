using UnityEngine;
using MediaPipe.Unity;

public class HandGestureRecognizer : MonoBehaviour
{
    [SerializeField] private HandLandmarker handModel;

    void Update()
    {
        if (handModel.IsTracking)
        {
            var landmarks = handModel.GetLandmarks(0);

            // Example: Detecting a fist as an action
            if (IsFist(landmarks))
            {
                Debug.Log("Action triggered!");
                // Insert callback for application logic here
            }
        }
    }

    bool IsFist(Vector3[] landmarks)
    {
        // Minimum distance test between finger tips and palm
        float thumbIndexDistance = Vector2.Distance(
            new Vector2(landmarks[4].x, landmarks[4].y),
            new Vector2(landmarks[8].x, landmarks[8].y)
        );

        return thumbIndexDistance < 0.1f;
    }
}