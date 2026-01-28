# Handbuch für das AI-in-XR-Kursvorlagen 

Dieses Handbuch erklärt, wie Sie die AI-in-XR-Vorlage für die Entwicklung von XR-Anwendungen mit KI-Integration verwenden können.

## Einrichtung des Projekts

1. **Erstellen eines neuen Unity-Projekts**:
   - Öffnen Sie Unity Hub
   - Erstellen Sie ein neues 3D-Projekt 
   - Benennen Sie es „AI-in-XR-Projekt"

2. **Installieren der erforderlichen Abhängigkeiten**:
   - AR Foundation package
   - ARCore/ARKit-Pakete (für mobile XR)
   - MediaPipe Unity Plugin
   - Vosk Speech-to-Text-Bibliothek 
   - Hugging Face/Transformers API oder lokales LLM

3. **Importieren der Vorlage**:
   - Kopieren Sie die Vorlagen-Dateien in Ihr Unity-Projekt 
   - Stellen Sie eine ordnungsgemäße Ordnerstruktur sicher 

## Verwendung der Gestenerkennung

### Einrichtung
1. Fügen Sie dem `HandGestureRecognizer`-Komponente zu einem GameObject in Ihrer Szene hinzu  
2. Weisen Sie den von Ihrer MediaPipe-Einrichtung stammenden `HandLandmarker` zu 
3. Konfigurieren Sie die AR-Foundation und das MediaPipe Hands Plugin 

### Funktionsweise
- Das System verfolgt mithilfe von MediaPipe Hand-Landmarks  
- Es erkennt, wenn eine Faustgeste durch Messung des Abstands zwischen Daumen und Zeigefingerspitzen erkannt wird 
- Bei Erkennung einer Faust wird „Action triggered!“ in der Konsole protokolliert 

### Erweiterungsmöglichkeiten
- Fügen Sie weitere Gestenerkennungsalgorithmen hinzu  
- Integrieren Sie 3D-Modell-Anhänge für kontextuelle Interaktionen 
- Verbinden Sie mit ML.NET für fortgeschrittene Gestenerkennung 

## Verwendung des Dialogsystems

### Einrichtung
1. Fügen Sie dem `AIDialogueManager`-Komponente zu einem GameObject in Ihrer Szene hinzu  
2. Konfigurieren Sie den Modellpfad für Ihr lokales LLM 
3. Richten Sie UI-Elemente für Benutzereingaben und AI-Antworten ein 

### Funktionsweise
- Das System verarbeitet Benutzereingaben mithilfe von `ProcessInput()`  
- Es generiert Antworten durch ein einfaches Mustererkennungssystem 
- Antworten werden über das Ereignis `OnDialogueResponse` gesendet  

### Erweiterungsmöglichkeiten
- Ersetzen Sie den Ersatzantwortgenerator durch eine reale LLM-Integration 
- Fügen Sie multimodale Interaktionen mit SAM/CLIP hinzu  
- Implementieren Sie Retrieval-augmented Generation-Muster 
- Verbinden Sie mit Web-APIs für den Wissenszugriff 

## Testen

Die Vorlage enthält ein einfaches Testrahmenwerk:
- `GestureTests.cs` enthält Einheitstests für die Gestenerkennung  
- Führen Sie Tests mithilfe des Unity Test Runners aus 
- Die Tests validieren, ob die Faustgesteerkennung korrekt funktioniert 

## Integration mit AR/VR

### Integration der AR-Foundation
- Verwenden Sie die AR Foundation für XR-Einrichtungen  
- Verbinden Sie MediaPipe Hands mit dem AR-Kamera-Stream 
- Implementieren Sie Gestenerkennung im AR-Kontext  

### Visuelle Ausgabe
- Nutzen Sie TextMeshPro, um AI-Antworten anzuzeigen 
- Erstellen Sie interaktive UI-Elemente für Benutzereingaben  
- Fügen Sie 3D-Modelle hinzu, die auf Gesten reagieren 

## Entwicklungsplan

Die Vorlage folgt diesem Entwicklungsverlauf:
1. **Minimales Prototyp**: Grundlegende Gestenerkennung und Dialogsystem 
2. **Echtzeitinteraktion**: Implementierung von Live-Geste- und Spracherkennung  
3. **Kontextuelle Erweiterungen**: Hinzufügen kontextueller Verhaltensweisen und fortschrittlicher AI-Funktionen  
4. **Erstellung des Evaluationsrahmens**: Implementierung von Metriken und Testing für die AI-Performance 

## Best Practices

### Modulares Design
- Trennen Sie Erkennungsalgorithmen von Anwendungsverhalten 
- Nutzen Sie ein Plugin-Strukturierungsmodell für verschiedene AI-Komponenten  
- Halten Sie den XR- und AI-Systemcode sauber getrennt 

### Performancebetrachtungen
- Optimieren Sie die Landmarkenverarbeitung für Echtzeitleistung  
- Verwenden Sie angemessene Threads für AI-Berechnungen 
- Implementieren Sie effiziente Speicherhaltung für XR-Anwendungen 

### Testen 
- Schreiben Sie umfassende Einheitstests für AI-Komponenten 
- Testen Sie die Gestenerkennung bei verschiedenen Händepositionen  
- Validieren Sie Dialogsystemantworten unter verschiedenen Eingaben



----------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------


# Usage Guide for AI-in-XR Course Template

This guide explains how to use the AI-in-XR course template for developing XR applications with AI integration.

## Setting Up the Project

1. **Create a new Unity project**:
   - Open Unity Hub
   - Create a new 3D project
   - Name it "AI-in-XR-Project"

2. **Install required dependencies**:
   - AR Foundation package
   - ARCore/ARKit packages (for mobile XR)
   - MediaPipe Unity Plugin
   - Vosk Speech-to-Text Library
   - Hugging Face/Transformers API or local LLM

3. **Import the template**:
   - Copy the template files into your Unity project
   - Ensure proper folder structure

## Using Gesture Recognition

### Setup
1. Add the `HandGestureRecognizer` component to a GameObject in your scene
2. Assign the `HandLandmarker` from your MediaPipe setup
3. Configure the AR Foundation and MediaPipe Hands plugin

### How It Works
- The system tracks hand landmarks using MediaPipe
- It detects when a fist gesture is made by measuring the distance between thumb and index finger tips
- When a fist is detected, it logs "Action triggered!" to the console

### Extending Functionality
- Add more gesture detection algorithms
- Integrate with 3D model attachments for contextual interactions
- Connect to ML.NET for more advanced gesture recognition

## Using Dialogue System

### Setup
1. Add the `AIDialogueManager` component to a GameObject in your scene
2. Configure the model path for your local LLM
3. Set up UI elements for user input and AI responses

### How It Works
- The system processes user input through `ProcessInput()`
- It generates responses using a simple pattern matching system
- Responses are sent via the `OnDialogueResponse` event

### Extending Functionality
- Replace the dummy response generator with actual LLM integration
- Add multimodal interaction with SAM/CLIP
- Implement Retrieval-augmented Generation patterns
- Connect to Web APIs for knowledge access

## Testing

The template includes a basic test framework:
- `GestureTests.cs` contains unit tests for gesture detection
- Run tests using Unity's Test Runner
- Tests validate that fist gesture detection works correctly

## Integration with AR/VR

### AR Foundation Integration
- Use AR Foundation for XR setup
- Connect MediaPipe Hands to AR camera stream
- Implement gesture recognition in AR context

### Visual Output
- Use TextMeshPro for displaying AI responses
- Create interactive UI elements for user input
- Add 3D models that respond to gestures

## Development Path

The template follows this development path:
1. **Minimal Prototype**: Basic gesture recognition and dialogue system
2. **Real-time Interaction**: Implement live gesture and voice recognition
3. **Contextual Extensions**: Add contextual behaviors and advanced AI features
4. **Create Evaluation Framework**: Implement metrics and testing for AI performance

## Best Practices

### Modular Design
- Keep detection logic separate from application behavior
- Use plugin structure for various AI components
- Maintain clean separation between XR and AI systems

### Performance Considerations
- Optimize landmark processing for real-time performance
- Use appropriate threading for AI computations
- Implement efficient memory management for XR applications

### Testing
- Write comprehensive unit tests for AI components
- Test gesture recognition with various hand positions
- Validate dialogue system responses under different inputs