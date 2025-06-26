

# 🤖 CyberBot — A Friendly Cybersecurity Assistant (WPF)

Welcome to **CyberBot**, a C# WPF application designed to educate users about cybersecurity in a fun, interactive, and user-friendly way. This project was built for my PROG6221 Practical Assessment (POE) and includes a combination of features such as task management, cybersecurity quizzes, natural language input, and chatbot-style interactions.

---

## 📌 Purpose

CyberBot helps users:
- Learn cybersecurity concepts through fun quizzes and tips.
- Manage digital security goals with reminders.
- Chat and ask questions about online safety.
- Receive responses that reflect empathy and encouragement.

---

## 🎯 Key Features

### ✅ **Task 1: Add and Manage Cybersecurity Tasks**
- Add tasks with a title, description, and date/time reminders.
- Mark tasks as completed or delete them.
- Clear and organized UI with a separate `AddTaskWindow`.

### ✅ **Task 2: Take a Cybersecurity Quiz**
- 10 randomized multiple-choice questions.
- Each question includes an educational explanation.
- Visual feedback and scoring system.
- Retry option available at the end.

### ✅ **Task 3: NLP Input & Chatbot **
- Keyword detection lets the user type commands like:
  - “Add a task”
  - “Remind me to update my password”
  - “Start quiz”
- Includes:
  - 🎯 Sentiment detection (e.g. “I’m confused” triggers a helpful reply).
  - ❓ Custom questions (e.g. “What is phishing?”).
  - 🧠 FAQs (e.g. “Who are you?” or “Tell me a joke.”)
- Users can also click buttons or use text input.

### ✅ **Task 4: Activity Logging**
- Tracks and logs important actions:
  - Task added
  - Task completed
  - Quiz started
- Users can view the full **Activity Log** from the main window.

---

## 🎬 Startup Experience

- On launch, CyberBot plays an **audio greeting** and asks the user for their name.
- Displays a **custom welcome message** (e.g. “Welcome to CyberBot, Khensani!”).
- Then opens the main menu automatically.

---

## 🛠️ Technology Stack

- **.NET WPF (C#)** — for desktop interface and logic
- **XAML** — for UI design
- **MVVM-inspired layout** — keeping UI logic separated
- **Windows Media APIs** — for audio playback
- **Custom logic** — for NLP, sentiment, and keyword processing

---

---

## 🚀 How to Run the Project

1. Open the solution in **Visual Studio 2022 or newer**.
2. Make sure NuGet packages are restored (if used).
3. Set `CyberBot1` as the startup project.
4. The **Introduction Window** will launch first.

---

## 🎨 UI & Design Notes

- Soft color palette for better accessibility.
- Icons used for easy understanding of buttons.
- Scroll-friendly design to accommodate all screen sizes.
- Input box accepts keywords.
- Animated audio greeting in the introduction.

---

## 💡 Sample Inputs

- `"Add a task"`
- `"Set a reminder for tomorrow"`
- `"Start quiz"`
- `"Give me a tip"`
- `"I’m confused"`
- `"Tell me about firewalls"`

---

## 🙏 Acknowledgements

-W3School
- Guidance from PROG6221 curriculum
- Portions assisted by ChatGPT for planning and structuring responses

---


