# Examination System (OOP Project)

This is an object-oriented Examination System developed using C#. It simulates a real exam environment for both **Final** and **Practical** exams with different question types and structured data models.

## 🧩 Features

- Base `Question` class with subclasses:
  - `TrueFalseQuestion`
  - `MCQQuestion`
- Base `Exam` class with:
  - `FinalExam` (shows student answers + grade)
  - `PracticalExam` (shows only correct answers)
- `Answer` class with ID and Text
- `Subject` class with linked exam object
- Supports dynamic exam creation and display
- Uses class composition and inheritance principles

## 🧱 Class Structure

- `Question` (Base)
  - `MCQQuestion`
  - `TrueFalseQuestion`
- `Answer`
- `Exam` (Base)
  - `FinalExam`
  - `PracticalExam`
- `Subject`

## 🧪 Exam Types

| Type          | Question Types          | Result Display                       |
|---------------|--------------------------|--------------------------------------|
| Final Exam    | MCQ + True/False         | Shows questions, student answers, and total grade |
| Practical Exam| MCQ only                 | Shows only correct answers           |

## 🛠️ How to Run

1. Clone the repository
2. Open in Visual Studio or any C# IDE
3. Build and run the project
4. Choose exam type and input data accordingly

## 📁 Project Structure

