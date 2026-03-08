# Learn How To Make Games - Unity Project

This project is a simple 3D game created in Unity. The player guides a cube through an obstacle course, avoiding collisions to reach the end of the level. It includes basic features such as player movement, collision detection, score tracking, level progression, and a simple UI menu.

## Disclaimer / Notice

**Important:** This program is not intended for actual use or distribution. 

It is strictly a learning project that I made while following the excellent "How to make a Video Game in Unity" tutorial series by the YouTuber **Brackeys**. 

You can find the tutorial playlist here:
[How to make a Video Game in Unity (Basics) - Brackeys](https://www.youtube.com/watch?v=j48LtUkZRjU&list=PLPV2KyIb3jR5QFsefuO2RlAgWEz6EvVi6&index=1)

## Scripts Overview

The core logic of the game is located in the `Assets/Script/` directory:
- `PlayerMovement.cs`: Handles physics-based movement using the new Input System (WASD).
- `PlayerCollision.cs`: Detects when the player hits an obstacle and triggers a game over.
- `CameraFollowPlayer.cs`: Keeps the camera positioned relatively behind the player cube.
- `GameManager.cs`: Manages the game state, including restarting the game upon failure and completing levels.
- `Score.cs`: Tracks and displays the player's progress distance.
- `LevelComplete.cs` / `EndTrigger.cs`: Handles reaching the finish line and transitioning levels.
- `Menu.cs` / `Credits.cs`: Simple UI scripts for the main menu and the end sequence.
