Course Template for XR + AI - Minimal Examples & Approaches
Example 1: Basic Framework for Gesture Recognition with AR Foundation (Task 1.1 & 1.2)
Overview
This template provides a Unity-AR scene with MediaPipe Hands integration that serves as the basis for contextual interactions.

// HandGestureRecognizer.cs  
using UnityEngine;  
using MediaPipe.Unity;  

public class HandGestureRecognizer : MonoBehaviour {  
    [SerializeField] private HandLandmarker handModel;  

    void Update() {  
        if (handModel.IsTracking) {  
            var landmarks = handModel.GetLandmarks(0);  

            // Example: Detecting a fist as an action  
            if(IsFist(landmarks)) {  
                Debug.Log("Action triggered!");  
                // Insert callback for application logic here  
            }  
        }  
    }  

    bool IsFist(Vector3[] landmarks) {  
        // Minimum distance test between finger tips and palm  
        float thumbIndexDistance = Vector2.Distance(  
            new Vector2(landmarks[4].x, landmarks[4].y),  
            new Vector2(landmarks[8].x, landmarks[8].y)  
        );  

        return thumbIndexDistance < 0.1f;  
    }  
}  
Procedure
AR Foundation Setup: Configure ARCore/Kit in Unity
Install the MediaPipe Hands plugin and connect the camera stream
Initialize landmark detection pipeline (HandLandmarker)
Implement simple gesture recognition via distance calculations
Create callback functions for contextual actions
Adaptation Potential
Integration of Vosk for voice commands (Task 1.1)
Extension to include more complex gesture algorithms (e.g., ML.NET)
Linkage with 3D model attachments (for Task 1.2)
Example 2: Basic Framework for Dialogue System with LLM (Task 1.3 & Application Enhancement)
Overview
This template implements a minimal chatbot in Unity that responds to user input and features simple text generation capabilities.

// AIDialogueManager.cs  
using UnityEngine;  
using System.Collections.Generic;  

public class AIDialogueManager : MonoBehaviour {  
    [SerializeField] private string modelPath = "OpenChatKit";  

    public delegate void DialogueCallback(string response);  
    public static event DialogueCallback OnDialogueResponse;  

    Queue<string> conversationHistory = new();  

    public void ProcessInput(string userInput) {  
        // Simple prompt construction  
        string prompt = CreatePrompt(userInput);  

        // Dummy LLM response (replaced by model later on)  
        string aiResponse = GenerateDummyResponse(prompt);  

        OnDialogueResponse?.Invoke(aiResponse);  
    }  

    string GenerateDummyResponse(string prompt) {  
        if(prompt.Contains("Hallo")) return "Guten Tag! Wie kann ich Ihnen helfen?";  
        // ... additional simple pattern matching  
        return "Ich verstehe nicht ganz, könnten Sie das bitte wiederholen?";  
    }  
}  
Procedure
Load a local LLM model (e.g., via OpenChatKit or Hugging Face)
Create simple prompt templates for different contexts
Secure text generation in the Unity thread with Async/Await or Coroutine
Integration into an AR/VR scene with visual output field (TextMeshPro)
Extend by TTS and STT components
Adaptation Potential
Integration of SAM/CLIP for multimodal interaction (image recognition + text)
Implementation of Retrieval-augmented Generation patterns
Connection to Web APIs for comprehensive knowledge access
Technical Recommendations for Coding Agents
Modularization:

Separate detection logic (gestures/speech) and application behavior
Plugin structure for various AI components
Development Path
graph TD
  A[Minimal Prototype] --> B[Real-time Interaction]
  B --> C[Contextual Extensions]
  C --> D[Create Evaluation Framework]
Important Dependencies:

MediaPipe Unity Plugin (Hands/Poses)
AR Foundation + ARCore/ARKit
Vosk Speech-to-Text Library
Hugging Face/Transformers API or local LLM
Test Framework Recommendation
[TestFixture]  
public class GestureTests {  
    [Test]  
    public void TestFistGestureDetection() {  
        // Mocked Landmark Data setup  
        var landmarks = CreateLandmarks(); 

        var result = HandGestureRecognizer.IsFist(landmarks);  
        Assert.IsTrue(result, "Fist detection failed");  
    }  
}  