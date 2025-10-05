# Take That Risk

**Take That Risk** is an interactive quiz-based game built in **C# (Windows Forms)** with an integrated **SQL Server database**. Inspired by *The Million Pound Drop*, the game challenges players to risk virtual money on multiple-choice questions while testing their knowledge across various categories.

---

## 🧩 Overview

Players begin with **£1,000,000** and must strategically distribute their funds across possible answers to multiple-choice questions.  
If the chosen answer is correct, the amount placed on that option is retained; any funds placed on incorrect answers are lost. The game continues until the player has no money left or completes all available rounds.

This project demonstrates skills in **C# programming**, **database integration**, and **user authentication**, while recreating the tension and excitement of a high-stakes quiz show.

---

## 🎮 Gameplay Screenshots

![Take That Risk Gameplay](Main-Menu-Screenshot.jpg)

---

## ⚙️ Features

- 💰 **Gameplay Inspired by The Million Pound Drop**  
  Players start with £1,000,000 and must divide their funds between multiple answers.

- 📚 **Dynamic Question Bank**  
  All questions, categories, and multiple-choice options are stored in a **SQL Server** database.

- 👤 **Player Accounts and Leaderboard**  
  Players can **create an account**, **log in**, and **compete for top scores** on a persistent leaderboard.

- 🧑‍🏫 **Teacher/Admin Mode**  
  Teachers can log in with admin credentials to **add, edit, or remove questions** directly from the database.

- 💾 **Secure Database Connection**  
  The game connects to a local SQL database to store user details, scores, and question data securely.

- 🎨 **User-Friendly Interface**  
  Built using Windows Forms, the game offers a clean and responsive design, intuitive navigation, and engaging visuals.

---

## 🧠 How to Play

1. Launch the app and **create an account** or **log in**.
2. Choose a **category** from the available options.
3. Read the question carefully and **distribute your funds (£1M)** among the answer options.
4. Click **Submit** — only the amount placed on the correct answer is carried forward!
5. Continue playing until your balance reaches £0 or you complete all rounds.
6. Your **final score** is saved to the **leaderboard**.

---

## 🧑‍🏫 Teacher/Admin Features

1. Log in using **teacher credentials**.
2. Access the **Question Management Panel**.
3. Add:
   - Question text
   - Multiple-choice answers
   - Correct answer
   - Category name
4. Save changes directly to the **SQL database**.

---

## 💻 Installation and Setup

### 1️⃣ Requirements

- **Windows 10 or later**
- **.NET Framework 4.8 or higher**
- **Visual Studio 2022 or higher** (for development)

## Download

You can download the latest version of the app here:

[Download BlockchainApp v1.0](https://github.com/takieddine17/Take-That-Risk/releases/download/v1.0/TTR.Test.exe)
