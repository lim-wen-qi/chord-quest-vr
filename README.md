# Chord Quest — VR Music Puzzle Game

A room-based VR music puzzle game developed in Unity and C#, where players learn basic musical notes and rhythm through interactive challenges.

## Gameplay Demo

https://github.com/user-attachments/assets/edf1e337-16d3-4eb3-a1e3-612895d877b3

## About

Chord Quest is an VR experience designed to introduce beginners to basic musical concepts through puzzle-based challenges.

Players move through a series of rooms, completing note and rhythm challenges before reaching a final piano sequence.

## Level Design

### 3D Asset Modelling

Environment and gameplay assets were modelled in Blender, including structural components, furniture, musical objects, and interactive elements.

<img width="1596" height="1411" alt="blender-asset" src="https://github.com/user-attachments/assets/7c5cc374-83b1-46bc-99ef-388407d0b3ab" />

### Level Assembly

The assets were imported into Unity and used to build the complete room layout. Each room was designed around a different musical challenge, leading up to the final piano sequence.

<img width="1293" height="877" alt="image" src="https://github.com/user-attachments/assets/901a6a5f-485b-448e-9cb3-31a1bbeccadc" />

### In-Game Result

<img width="2100" height="1287" alt="gameplay" src="https://github.com/user-attachments/assets/18c1de93-65e3-4709-906c-9e65f06af955" />

## Key Features

- Room-based VR puzzle progression
- Note and rhythm puzzles
- VR object grabbing and manipulation
- Teleport locomotion
- Audio and visual feedback
- Final interactive piano sequence

## Technical Implementation

Chord Quest was developed in Unity using C#, OpenXR, and XR Interaction Toolkit for VR input and interaction.

### VR Interaction & Locomotion

XR Interaction Toolkit is used for controller-based object grabbing and interaction. Teleport locomotion allows the player to move between different areas of the environment without relying on continuous movement.

### Puzzle & Progression Systems

Different C# scripts handle puzzle validation and progression throughout the rooms. `NoteBox` and `PuzzleManager` check note placement and determine when a puzzle has been completed, while `DoorOpener` controls access to the next area after the required puzzle conditions are met.

### Final Piano Sequence

The final room brings the earlier music challenges together in an interactive piano sequence. `SongManager` checks the notes played by the player, handles correct and incorrect inputs, provides retry feedback, and detects when the
sequence has been completed.

## Technologies

- Unity
- C#
- XR Interaction Toolkit
- OpenXR
- Blender
- Universal Render Pipeline (URP)

## Testing & Evaluation

User testing was conducted to evaluate puzzle interactions, controls, navigation, and overall usability.

Teleport locomotion was used to reduce the need for continuous VR movement and provide a more comfortable way to move between rooms.

## Project Context

**Virtual Reality Module Project**  
Bachelor of Science (Honours) in Computer Science  
University of London
