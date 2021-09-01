# CSharpSpecflowSeleniumNunitFramework
### This framework aautomates the VIC Roads web application using Selenium C# SpecFlow and NUnit.
#### The main test is to navigate from Step 1 of the unregistered vehicle permit page to Step 2. The data is passed via Scenario Outline (Examples). The test is considered as pass if the navigaton from Step 1 to Step 2 is successful. The same has been covered in this framework.


## Uses:
SpecFlow (BDD)
Selenium (WebDriver)
NUnit 3.x
utilises Page Object Model pattern


## Getting started:

## Visual Studio Config
* Install Visual Studio (Community 2019)

**Open Visual Studio and configure the following;**
* Install NuGet (package manager)
* Connect to github project
* Use NuGet to install Specflow, Nunit and Selenium:
* NUnit 3.13.1
* NUnitTestAdapter 3.17.0
* SpecFlow
* Specflow.NUnit 3.9.22
* Selenuium Web Driver 3.141.0
* Selenium Supports 3.141.1

## Clone
```
$ git clone https://github.com/shaliniPremkumar/CSharpSpecflowSeleniumNunitFramework.git
```

## How to Compile
To build or rebuild the project:
1. In Solution Explorer, choose or open the project.
2. On the menu bar, choose **Build**, and then choose either ***Build ProjectName*** or ***Rebuild ProjectName***. Choose Build ProjectName to build only those project components that have changed since the most recent build.

## How to Run
1. To open the project, double-click or tap on the **.csproj** from the Windows File Explorer, or from Visual Studio, choose **Open a project**, browse to find the ***project (.csproj) file***, and choose the project file.
2. After the projects loads in Visual Studio, press **Ctrl+F5** (Start without debugging) or use the ***green Start button*** on the Visual Studio toolbar to run the program. 

## Assumptions
* *The test is considered a Pass, when the Step 2 text is displayed on the screen.*
* *Test data is validated by the web application. No extra validations or checks are done in this framework.*
* *The code looks for the error summary, if the navigation is not successful.*

### Input
- [X] Examples via Scenario Outline
- [X] .json

### Output
- [X] NUnit Reports



