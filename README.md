# aeditor
AEditor is Assembler editor that makes it easier to write, edit, compile and debug Turbo Assembler code. Based on ScintillaNET control. It's developed in C#

## Features
 - Code highlighting (based on ScintillaNET control)
 - Compile and link assembler code in Turbo assembler in one click. Running compiled program in Turbo debugger is an option.
 - Quick navigation to errors detected by compiler
 - Easy to use
 - Russian or English interface depending on OS interface language settings
 
## Get started
 
First you need to **set up** the program. In Settings dialog enter path to folder where tasm.exe and tlink.exe is. Also you may need to specify commandline options for tasm.exe and tlink.exe. 

**Usage** of the program is simple. Just click "Link" button and code in the textbox will be compiled and linked or you will get a window with a list of error messages. Double click on an error navigates you to the place of code where an error occurs.

## Screenshot

![](docs/AEscreen.PNG)
