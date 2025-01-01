# 3D Sphere Puzzle Game

## Overview
This Unity project is a dynamic 3D puzzle game where the player controls a gold sphere, navigating a colorful grid of tiles and avoiding obstacles. The objective is to turn all blue tiles green while avoiding pitfalls, hazards, and enemies. The game combines puzzle-solving with platformer mechanics to challenge the player's spatial awareness and precision.

---

## Features

### Core Gameplay
- **Player Control:** 
  - Move the gold sphere using the arrow keys (`Up`, `Down`, `Left`, `Right`).
  - The sphere rolls across the level with realistic physics-based movement.

### Tile Interactions
- **Blue Tiles:** 
  - Turn green when the sphere rolls over them, earning the player +100 points per tile.
- **Green Tiles:** 
  - Indicate progress; no additional interaction.
- **Brown Tiles (Pitfalls):** 
  - Disappear when the sphere rolls over them, creating a pit. Falling into a pit ends the game.
- **Purple Tiles (Springs):** 
  - Launch the sphere into the air upon contact. The sphere may land back on the map or fall out of bounds, resulting in game over.

### Enemy Interaction
- **Moving Cylinder:** 
  - Acts as an enemy that moves vertically across the map.
  - Contact with the cylinder results in game over.

### Win/Lose Conditions
- **Win:** 
  - Turn all blue tiles into green tiles to complete the level and display a congratulatory message.
- **Lose:** 
  - Fall into a pit or out of bounds.
  - Make contact with the moving cylinder enemy.

### UI and Feedback
- **Score Display:** 
  - Real-time score updates based on converted blue tiles (+100 points per tile).
- **Game Over Screen:** 
  - Appears when the player loses, indicating the cause of failure.
- **Victory Screen:** 
  - Displays a congratulatory message when all blue tiles are green.

---

## Development Details
- **Engine:** Unity
- **Physics:** Unity's Rigidbody physics for realistic sphere movement.
- **Level Design:** 
  - A grid-based map with varying tile types for strategic navigation.
  - A moving enemy to add dynamic difficulty.
- **UI:** 
  - On-screen score tracker.
  - Game over and victory messages.

---

## How to Play
1. Launch the game and control the sphere using the arrow keys.
2. Roll over blue tiles to turn them green and increase your score.
3. Avoid pitfalls (brown tiles), stay on the map, and avoid the moving cylinder enemy.
4. Use purple tiles strategically to navigate the level but beware of falling out of bounds.
5. Turn all blue tiles into green to win the game!

---

## Future Enhancements
- Add new levels with increasing difficulty.
- Introduce timed challenges for an added layer of difficulty.
- Implement collectibles or power-ups for enhanced gameplay mechanics.
- Add customizable themes for tile and sphere appearances.
