# 3D Sphere Puzzle Game
####### [Return to Portfolio](https://github.com/EricDelgado993/Portfolio)

## Overview
This Unity project is a dynamic and engaging 3D puzzle game where players control a gold sphere to navigate a grid of colorful tiles. The objective is to turn all blue tiles green by rolling over them while avoiding hazards and enemies. The game features a score system, realistic physics, and interactive mechanics to challenge players' skills.

---

## 📂 **Project Files**
- [GameManager.cs](https://github.com/EricDelgado993/3D-Sphere-Puzzle/blob/main/Assets/GameManager.cs)
- [PitFall.cs](https://github.com/EricDelgado993/3D-Sphere-Puzzle/blob/main/Assets/PitFall.cs)
- [PlayerController.cs](https://github.com/EricDelgado993/3D-Sphere-Puzzle/blob/main/Assets/PlayerController.cs)
- [Stable.cs](https://github.com/EricDelgado993/3D-Sphere-Puzzle/blob/main/Assets/Stable.cs)
- [vEnemy.cs](https://github.com/EricDelgado993/3D-Sphere-Puzzle/blob/main/Assets/vEnemy.cs)

---

## Screenshots
![](https://github.com/EricDelgado993/3D-Sphere-Puzzle/blob/main/Screenshots/screen1.png) ![](https://github.com/EricDelgado993/3D-Sphere-Puzzle/blob/main/Screenshots/screen2.png)

---

## Features

### Core Gameplay
- **Player Control:** 
  - Use arrow keys (`Up`, `Down`, `Left`, `Right`) to control the sphere's movement.
  - Rolling physics implemented for realistic interaction with the environment.

### Tile Interactions
- **Blue Tiles:** 
  - Turn green when rolled over, adding +100 points to the score.
  - All tiles must be turned green to win.
- **Green Tiles:** 
  - Indicate progress; turning all blue tiles green triggers the win condition.
- **Brown Tiles (Pitfalls):** 
  - Disappear when touched, creating a pit.
  - Falling into a pit results in game over.
- **Purple Tiles (Springs):** 
  - Launch the sphere into the air when stepped on.
  - May cause the sphere to land back on the map or fall out of bounds, resulting in game over.

### Enemy and Hazards
- **Enemy Cylinder (vEnemy):**
  - Moves vertically across the map.
  - Contact with the cylinder results in game over.
- **Arena Bounds:**
  - Falling out of bounds ends the game.
  - Managed by the `GameManager` script, which checks the player's position relative to the arena's bounds.

### Game Manager Features
- **Score System:** 
  - Tracks and displays the score in real time.
  - Adds +100 points for each blue tile turned green.
  - Triggers the win condition at a score of 3600 points.
- **Win Condition:** 
  - Displays a "Congratulations" message and disables player controls when all tiles are green.
- **Restart Mechanism:** 
  - Automatically restarts the level when the player falls out of bounds or makes contact with a hazard/enemy.

### Scripts and Mechanics
- **GameManager.cs:**
  - Central script managing the game state, score, and win conditions.
- **PlayerController.cs:**
  - Handles player movement and collision detection.
  - Applies vertical force on purple tiles and restarts the level upon falling out of bounds.
- **Stable.cs:**
  - Changes tile color to green upon collision with the player and invokes the score update in `GameManager`.
- **PitFall.cs:**
  - Removes brown tiles upon collision with the player.
- **vEnemy.cs:**
  - Controls enemy cylinder's movement, creating a dynamic obstacle.

### Visual and UI Features
- **Score Display:** 
  - Real-time score updates displayed on the screen.
- **Win Message:** 
  - Displays "Congratulations" upon winning.
- **Hazard Effects:**
  - Realistic physics for pitfalls and springs.
  - Vibrant tile color changes to indicate progress.

---

## How to Play
1. Control the gold sphere using the arrow keys.
2. Roll over blue tiles to turn them green and score points.
3. Avoid hazards like pitfalls, springs, and the moving enemy cylinder.
4. Stay within the arena bounds to avoid falling out of the map.
5. Turn all blue tiles green to win the game.
