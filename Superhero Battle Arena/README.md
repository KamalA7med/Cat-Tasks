# 🦸‍♂️ Superhero Battle Arena 🦸‍♀️

## ⚡ Overview
**Superhero Battle Arena** is a **console-based C# game** where heroes battle in **turn-based combat**. Players experience strategic fights using **unique hero types**, each with special abilities and attack styles. The game also includes **random critical damage** and **healing events** to keep battles exciting and unpredictable! 🎲🔥

---

## 🛡️ Heroes

### 1. 🗡️ Warrior
- **Description:** A strong melee fighter with high base power.
- **Attack Mechanism:** Deals **physical damage** equal to its power. Has a **1/3 chance** to deal **double damage** ("Over Damage") 💥.
- **Special Traits:** High durability and reliable damage output.

### 2. 🔮 Mage
- **Description:** A magical hero who attacks with **fire-based powers**.
- **Attack Mechanism:** Deals **magical damage** equal to its power. Has a **1/4 chance** to deal **double damage** 🔥.
- **Special Traits:** Can inflict **strong bursts of damage** unpredictably.

### 3. 🏹 Archer
- **Description:** A ranged hero who attacks from a distance.
- **Attack Mechanism:** Deals **ranged damage** equal to its power. Has a **1/5 chance** to deal **double damage** 🎯.
- **Special Traits:** Balances **damage and critical attack probability**.

---

## 🎮 Game Mechanics

### ⚔️ Attack
- Heroes attack others using the `Attack()` method.
- Base damage = hero's **Power**.
- Critical hits randomly **multiply damage**:
  - Warrior: 1/3 chance 💥
  - Mage: 1/4 chance 🔥
  - Archer: 1/5 chance 🎯
- Damage is subtracted from the enemy's health ❤️.

### ❤️ Healing
- Heroes can heal using the `Heal()` method.
- Default healing = **20 health points**.
- Chance for a **big heal (5×)** = 1/10 🎉.

### 📝 Status
- `Introduce()`: Shows hero **name, power, and health**.
- `Conditions()`: Shows hero's **current health**.

### ✅ Alive Check
- `IsAlive()`: Returns `true` if **health > 0**, else `false`.

---

## 🕹️ Gameplay
1. Start the game from `Program.cs` using `Game.StartGame()`.
2. Choose heroes and watch them battle!
3. Attacks and healing are displayed in the console with **fun messages** ✨.
4. Battles continue until one hero's **health reaches 0** 💀.

---

## 📂 Project Structure
- `BaseHero.cs` – Abstract class defining hero properties and methods.
- `Warrior.cs` – Implements **Warrior** hero.
- `Mage.cs` – Implements **Mage** hero.
- `Archer.cs` – Implements **Archer** hero.
- `Program.cs` – Entry point to start the game.
- `Game.cs` – Handles **game logic**, turn-based battles, and hero management.

