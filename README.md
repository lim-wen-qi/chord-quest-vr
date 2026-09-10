# Chord Quest — VR Music Puzzle Game

A room-based VR music puzzle game developed in Unity and C#, featuring interactive musical challenges, object-based interactions, and VR locomotion.

## Gameplay Demo

https://github.com/user-attachments/assets/edf1e337-16d3-4eb3-a1e3-612895d877b3

## About

Chord Quest is an interactive VR experience designed to introduce beginners to musical notes and rhythm through puzzle-based challenges.

Players progress through multiple rooms, interacting with musical objects and completing note and rhythm puzzles before performing a final musical sequence.

## Level Design

### 3D Asset Modelling

<img width="1596" height="1411" alt="blender-asset" src="https://github.com/user-attachments/assets/7c5cc374-83b1-46bc-99ef-388407d0b3ab" />

Environment and gameplay assets were modelled in Blender, including structural components, furniture, musical objects, and interactive elements.

### Level Assembly

<img width="1293" height="877" alt="image" src="https://github.com/user-attachments/assets/901a6a5f-485b-448e-9cb3-31a1bbeccadc" />

The assets were imported and assembled in Unity to construct the room-based
VR environment. Players progress through different musical challenges before
reaching the final performance sequence.

### In-Game Result

<img width="2100" height="1287" alt="gameplay" src="https://github.com/user-attachments/assets/18c1de93-65e3-4709-906c-9e65f06af955" />

## Key Features

- Room-based VR puzzle progression
- Interactive note and rhythm challenges
- Controller-based object grabbing and manipulation
- Trigger-based puzzle interactions
- Teleport locomotion
- Audio and visual feedback
- Final interactive piano sequence

## Technical Implementation

The project was developed in Unity using C#, XR Interaction Toolkit, and
OpenXR for VR interaction and device support.

- `SongManager` manages the final piano sequence, including correct and incorrect inputs, retry feedback, completion, and scene progression
- `NoteBox` and `PuzzleManager` validate note placement and manage puzzle completion
- `DoorOpener` controls environmental progression when puzzle conditions are satisfied
- XR Interaction Toolkit handles controller-based object interaction and teleport locomotion
- Modelled environment assets in Blender and assembled them in Unity to construct the VR level

## Technologies

- Unity
- C#
- XR Interaction Toolkit
- OpenXR
- Blender
- Universal Render Pipeline (URP)

## Testing & Evaluation

User testing was conducted to evaluate puzzle interactions, controls, navigation, and overall usability.

Teleport locomotion was used with VR comfort in mind. Future evaluation could include more structured testing of simulator discomfort and locomotion comfort.

## Project Context

**Virtual Reality Module Project**  
Bachelor of Science in Computer Science  
University of London
