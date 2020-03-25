# Text Editor
> Simple text editor, you can save, edit and open .txt file. 

## Table of contents
* [General info](#general-info)
* [Screenshots](#screenshots)
* [Technologies](#technologies)
* [Setup](#setup)
* [Features](#features)
* [Status](#status)
* [Inspiration](#inspiration)
* [Contact](#contact)

## General info
This GUI is made in c#. Just a quick little project. Text Editor. Feel free to clone or download this repo.

## Screenshots
![](https://github.com/MarkoVitkovic/csh_GUI-MyEditor/blob/master/Bez%20naslova.png)

## Technologies
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)

## Setup
1.Open your Visual Studio Environment and Click File->New Project</br>
![](http://csharp.net-informations.com/gui/img/new-project.png)</br>
2.Then you will get a New Project Dialogue Box asking in which language you want to create a new project.</br>
![](http://csharp.net-informations.com/gui/img/visual-studio.png)</br>
3.Select Visual C# from the list, then you will get the following screen.</br>
![](http://csharp.net-informations.com/gui/img/form-control.png)</br>
4.Now you can add controls in your Form Control.</br>


## Learn More


To learn C#, check out the [C# docs](https://docs.microsoft.com/en-us/dotnet/csharp/).

## Code Examples
Code:</br>
`if(saveFileDialog1.ShowDialog() == DialogResult.OK)`</br>
			`{`</br>
				`using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))`</br>
				`{`</br>
					`writer.Write(textBox1.Text);`</br>
				`}`</br>
			`}`</br>


## Features
List of features ready and TODOs for future development
* Create new file
* Open existing file
* Edit new or existing file

To-do list:
* Tool box
* can open more formats

## Status
Project is: _finished_

## Inspiration
First csh GUI program from me.

## Contact
Created by [Marko Vitkovic](https://github.com/MarkoVitkovic) - feel free to contact me!
