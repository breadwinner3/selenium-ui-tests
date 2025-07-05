# selenium-ui-tests

# First Automation Project 🚀

This is my very first UI automation test project built using **C#**, **Selenium WebDriver**, and **NUnit**. It demonstrates the fundamentals of browser automation — navigating to a webpage and verifying its URL and title — using the **Page Object Model (POM)** design pattern.

## 📌 Technologies Used

- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Visual Studio Code](https://code.visualstudio.com/)
- [Selenium WebDriver](https://www.selenium.dev/)
- [NUnit Testing Framework](https://nunit.org/)
- [Google Chrome + ChromeDriver](https://chromedriver.chromium.org/)
- C#

## 🧪 What the Test Does

This project includes a test that:

1. Launches Google Chrome using Selenium WebDriver.
2. Navigates to [Bing.com](https://www.bing.com).
3. Waits for the page to fully load.
4. Verifies:
   - That the current URL is correct.
   - That the page title matches the expected value.

## 🧱 Folder Structure

FirstAutomationProject/
├── Drivers/
│ └── DriverSetup.cs # Initializes ChromeDriver
├── Tests/
│ └── GoogleTest.cs # Contains the test logic
├── FirstAutomationProject.csproj
└── README.md # You're reading it!

## 🛠️ How to Run the Test

1. Make sure you have .NET 8.0 SDK and Chrome installed.
2. Open the project folder in VS Code.
3. Restore and build the project:
   ```bash
   dotnet restore
   dotnet build
   dotnet test

  ## Goals   
This project is part of my learning journey to master UX test automation. Future goals include:

Writing end-to-end tests across multiple pages

Integrating test results and reports

Running tests on BrowserStack or other cloud environments

## 🤝 Connect With Me

I'm currently growing my skills as a QA Engineer with a focus on automation. Feel free to connect with me on LinkedIn if you're hiring, collaborating, or just want to say hello!
