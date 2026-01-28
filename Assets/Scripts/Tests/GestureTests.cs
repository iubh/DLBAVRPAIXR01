using UnityEngine;
using NUnit.Framework;

public class GestureTests 
{
    [Test]
    public void TestFistGestureDetection()
    {
        // Mocked Landmark Data setup  
        var landmarks = CreateLandmarks(); 

        var result = HandGestureRecognizer.IsFist(landmarks);  
        Assert.IsTrue(result, "Fist detection failed");
    }
    
    private Vector3[] CreateLandmarks()
    {
        // Create mock landmark data for a fist gesture
        // This is a simplified version - in practice, you'd have actual landmark data
        Vector3[] landmarks = new Vector3[21];
        
        // Set thumb tip (index 4) and index finger tip (index 8) close together to simulate fist
        landmarks[4] = new Vector3(0.3f, 0.3f, 0f);  // Thumb tip
        landmarks[8] = new Vector3(0.35f, 0.35f, 0f); // Index finger tip
        
        // Set other landmarks to some default values
        for (int i = 0; i < 21; i++)
        {
            if (i != 4 && i != 8)
            {
                landmarks[i] = new Vector3(0.5f, 0.5f, 0f);
            }
        }
        
        return landmarks;
    }
}