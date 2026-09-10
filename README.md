# Chord Quest — VR Music Puzzle Game

Chord Quest is a room-based VR music puzzle game developed in Unity and C#. It introduces beginners to musical notes and rhythm through interactive VR challenges, progressing through multiple puzzle rooms before culminating in a final musical sequence.

## Gameplay Demo

https://github.com/user-attachments/assets/edf1e337-16d3-4eb3-a1e3-612895d877b3

## About

The game combines music learning with interactive VR puzzle-solving. Players progress through a series of rooms where they interact with musical objects, solve note and rhythm-based challenges, and gradually apply what they have learned.

The experience was designed with beginner VR users in mind, using intuitive interactions and comfortable locomotion while providing audio and visual feedback throughout the puzzles.

## Key Features

- Room-based VR puzzle progression
- Interactive musical note and rhythm challenges
- Controller-based object grabbing and manipulation
- Trigger-based puzzle interactions
- Teleport locomotion for comfortable VR movement
- Audio and visual feedback for player actions
- Final musical sequence combining learned concepts

## Technical Implementation

The project was developed in Unity using C#, XR Interaction Toolkit, and OpenXR for VR interaction and device support.

The gameplay is organised across several scripts responsible for musical interactions, puzzle logic, game progression, and environmental behaviour.

- `SongManager` manages the final piano sequence, including correct and incorrect inputs, retry feedback, puzzle completion, and scene progression.
- `NoteBox` and `PuzzleManager` work together to validate note-block placement and determine when the placement puzzle has been completed.
- `DoorOpener` controls environmental progression when puzzle conditions are satisfied.
- VR interactions use controller-based object manipulation, trigger interactions, and teleport locomotion through XR Interaction Toolkit.

## Technologies

- Unity
- C#
- XR Interaction Toolkit
- OpenXR
- Universal Render Pipeline (URP)

## User Testing

User testing was conducted to evaluate puzzle interactions, controls, navigation, and overall usability of the VR experience.

The project also considered VR comfort through the use of teleport locomotion. Testing highlighted that a more detailed evaluation of simulator discomfort and locomotion comfort would be valuable in future iterations.

## Project Context

Chord Quest was developed as part of the **Virtual Reality** module for the Bachelor of Science in Computer Science programme at the University of London.

The project focused on applying VR interaction design, immersive environments, puzzle progression, and user testing to create an interactive music-learning experience.
