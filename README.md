Space Shooter Game:
A 2D space shooter game built with Unity. Shoot down enemies, earn points, and survive as long as you can in this retro-style arcade game.

Features:

Player Movement: Smooth left and right movement controls
Shooting Mechanics: Continuous bullet firing system
Enemy Spawning: Dynamic enemy waves that spawn at intervals
Score System: Real-time score tracking and display
Game Over State: Game over screen with restart functionality
Collision Detection: Bullet-enemy and player-enemy collision handling
Space Theme: Purple nebula background with pixel art sprites

How to Play:

Arrow Keys or A and D keys - Move player left and right
Space Bar - Shoot bullets
R Key - Restart game after game over
Objective - Destroy enemies to gain points. Don't let enemies touch your ship!

Project Structure:

Space Shooter Game/
├── Assets/
│   ├── Scripts/
│   │   ├── PlayerController.cs
│   │   ├── Bullet.cs
│   │   ├── Enemy.cs
│   │   ├── EnemySpawner.cs
│   │   ├── ScoreManager.cs
│   │   └── GameManager.cs
│   ├── Prefabs/
│   └── Scenes/
├── gitignore
├── README.md
└── LICENSE

Script Details:

PlayerController.cs - Reads input, moves player horizontally, instantiates bullets
Bullet.cs - Moves bullet upward, destroys on collision with enemy, updates score
Enemy.cs - Moves downward, triggers game over on collision with player
EnemySpawner.cs - Spawns enemy prefabs at random X positions at regular intervals
ScoreManager.cs - Singleton that tracks and displays current score
GameManager.cs - Singleton that manages game state, handles game over, and restart

Assets:

Free sprite assets from itch.io
Purple space background and pixel art characters
Creative Commons or free-to-use assets

Technical Details:

Engine: Unity 2D
Language: C#
Physics: Rigidbody2D with colliders
Input: Unity Input System

Getting Started:
 1. Clone this repository
 2. Open in Unity (2020.3 LTS or later recommended)
 3. Create prefabs for Player, Enemy, and Bullet with their respective scripts
 4. Set up your main scene with the player prefab instance, enemy spawner, score manager UI, and game manager
 5. Assign all prefabs in the Inspector
 6. Press Play and test

License:
This project is licensed under the MIT License. See the LICENSE file for details.

This project was developed as a core assignment for my Computer Science major specializing in Game Programming.Feel free to fork, modify, and use this code for your own projects.
Happy coding! 
