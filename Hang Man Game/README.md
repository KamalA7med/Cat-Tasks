# 🎮 Hang Man Game (C# Console Application)

## 📌 Description
Hang Man Game is a simple console-based word guessing game written in C#.

The player must guess the hidden word one character at a time before the hangman drawing is completed.

If the player makes 6 wrong guesses, the game ends and the hangman is fully drawn.

---

## 🚀 Features
- Random word selection
- ASCII Hangman drawing (7 stages)
- Tracks correct guesses
- Tracks wrong guesses
- Win/Lose detection
- Clean console interface
- Uses methods, arrays, and List<char>

---

## 🛠️ Technologies Used
- C#
- .NET Console Application
- Visual Studio

---

## 🧠 Game Logic

### 1️⃣ Random Word Selection
```csharp
string[] Words = { "bright", "active", "friend", "kindly", "spirit" };
Random random = new Random();
string word = Words[random.Next(0, Words.Length)];
