using UnityEngine;
using System.Collections.Generic;

public class AIDialogueManager : MonoBehaviour
{
    [SerializeField] private string modelPath = "OpenChatKit";

    public delegate void DialogueCallback(string response);
    public static event DialogueCallback OnDialogueResponse;

    Queue<string> conversationHistory = new();

    public void ProcessInput(string userInput)
    {
        // Simple prompt construction
        string prompt = CreatePrompt(userInput);

        // Dummy LLM response (replaced by model later on)
        string aiResponse = GenerateDummyResponse(prompt);

        OnDialogueResponse?.Invoke(aiResponse);
    }

    string CreatePrompt(string userInput)
    {
        // Simple prompt construction
        return $"User: {userInput}\nAI:";
    }

    string GenerateDummyResponse(string prompt)
    {
        if (prompt.Contains("Hallo") || prompt.Contains("Hello"))
            return "Guten Tag! Wie kann ich Ihnen helfen?";
        // ... additional simple pattern matching
        return "Ich verstehe nicht ganz, könnten Sie das bitte wiederholen?";
    }
}