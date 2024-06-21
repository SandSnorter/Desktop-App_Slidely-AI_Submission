# Slidely AI Submission - Desktop App
This repository contains the code for a Windows Desktop Application developed for Slidely AI. The application allows users to create and view submissions through a user-friendly interface. It is developed using Visual Studio and Visual Basic.

![Screenshot 2024-06-21 211745](https://github.com/SandSnorter/Desktop-App_Slidely-AI_Submission/assets/121429638/e0fe089c-1240-460d-9292-2d7fdac36b2c)

![Screenshot 2024-06-21 211653](https://github.com/SandSnorter/Desktop-App_Slidely-AI_Submission/assets/121429638/3b8f151e-89c7-449f-bcfb-522eede1239d)

![Screenshot 2024-06-21 211712](https://github.com/SandSnorter/Desktop-App_Slidely-AI_Submission/assets/121429638/98bce3bc-0756-4743-b30d-508237c16f3e)

![Screenshot 2024-06-21 211911](https://github.com/SandSnorter/Desktop-App_Slidely-AI_Submission/assets/121429638/c0c59fe4-b791-4579-ad09-1618a076969a)

## Features

### 1. Main Form
- View Submissions: Opens a new form to view submissions.
- Create New Submission: Opens a new form to create a new submission.

### 2. View Submissions Form
- Displays submitted entries one by one.
- Previous: Navigate to the previous submission.
- Next: Navigate to the next submission.
- By default, the first submitted form entry is shown.

### 3. Create Submission Form
- Editable fields for Name, Email, Phone Number, and GitHub repo link.
- Stopwatch with pause and resume functionality (does not reset on pause).
- Submit: Submits the details to the backend.
- 
### 4. Keyboard Shortcuts
- Validation for each input textbox has been implemented
### 5. Keyboard Shortcuts
- All buttons have keyboard shortcuts.
- For example, Ctrl + S submits the form on the Create New Submission page.

## Requirements
- Windows OS
- Visual Studio (not Visual Studio Code)
- Visual Basic

## Installation
### 1. Clone the repository:

```bash
    git clone https://https://github.com/SandSnorter/Desktop-App_Slidely-AI_Submission.git
```

### 2. Open the solution file (SlidelyAISubmissionApp.sln) in Visual Studio.

### 3. Build the solution to restore dependencies and compile the project.

## Usage

### 1. Main Form:

- Launch the application. The main form will appear with two buttons: "View Submissions" and "Create New Submission".
### 2. View Submissions:

- Click on "View Submissions" or use the assigned keyboard shortcut.
- The View Submissions Form will appear, displaying the first submission by default.
- Use the "Previous" and "Next" buttons or their respective keyboard shortcuts to navigate through submissions.
  
### 3. Create New Submission:

- Click on "Create New Submission" or use the assigned keyboard shortcut.
- Fill in the Name, Email, Phone Number, and GitHub repo link fields.
- Use the stopwatch button to pause/resume timing.
- Press "Submit" or use the Ctrl + S shortcut to submit the form.

## Keyboard Shortcuts
### 1. View Submissions Form:

- Ctrl + P: Previous submission
- Ctrl + N: Next submission
### 2. Create Submission Form:

- Ctrl + S: Submit form
