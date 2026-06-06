# 3D Endless Runner Game

A fast-paced and dynamic 3D Endless Runner game built in Unity using the **Universal Render Pipeline (URP)**. The project features physics-based reflex movement, procedural obstacle streaming, a clean modern input layout, and fully structured state management menus.

---

## 🚀 Key Features

* **URP Optimized Visuals:** Built on top of Unity's Universal Render Pipeline template for lightweight performance and modern post-processing support.
* **Reflex-Based 3D Movement:** Responsive character layout utilizing Unity’s modular state actions to dodge incoming barriers.
* **Complete UI/UX Lifecycle:** Seamless menu flows from an interactive main menu to live point tracking and a polished Game Over screen state.
* **Persistent Settings Architecture:** Ready-made engine integration configurations that preserve asset tracking and meta linkages cleanly across project imports.

---

## 📂 Project Architecture & Script Breakdown

The core interface, state controls, and assets are cleanly organized within the `Assets/` directory:

### ⚙️ Game State & UI Management
* **`startmanue.cs`**: Manages the main menu screen lifecycle, handling initialization hooks, player progression boots, and transition requests to the active running scene.
* **`Gameover_screen.cs`**: Listens for failure collision events, bringing up score tallies, retry hooks, and navigation pathways to return back to the main lobby.
* **`InputSystem_Actions.inputactions`**: The core input asset mapping modern mouse, keyboard, or controller layouts for navigation, jumping, or lane-shifting triggers.

### 📦 Asset Kits & Templates
* **`Course Library/`**: Contains the core 3D models, obstacle prefabs, environmental meshes, and textures that generate the running track dynamically.
* **`TextMesh Pro/`**: Handles crisp, scalable UI typography for real-time distance and score counters rendered onto the player's HUD.

---

## 🎮 Controls

The gameplay utilizes clean responsive mechanics to navigate the running tracks:

* **Navigate / Shift Lanes:** Use `A` / `D` or **Left / Right Arrow Keys** to move laterally.
* **Jump / Action:** Press the **Spacebar** or assigned input mappings to hurdle obstacles.

---

## 🛠️ Getting Started

### Prerequisites
* **Unity Editor:** Version 2021.3 LTS or modern Unity 6 versions recommended.
* **Render Pipeline:** Universal Render Pipeline (**URP**) package active.

### Installation & Setup

1. **Clone the repository** directly to your workstation:
   ```bash
   git clone [https://github.com/alirajput1014/Runner-Game.git](https://github.com/alirajput1014/Runner-Game.git)
