Spider-Man: Web of Shadows — PCPACK Tools Setup & Update Guide

For Kriby, Haruse, and me — enjoy ^^

This guide will help you set up the PCPACK Extractor with the latest updates and run it safely on your system using Python 3.10.6 and LZO.

Team note: We are three working on this project — each of us has our own style: Kriby, Haruse, and me. I also added my latest update to WOS tools. Everyone can use their own workflow while staying on the same setup.

 Download Prerequisites

Python 3.10.6 Installer (provided)

python_lzo-1.15-cp310-cp310-win_amd64.whl (provided)

PCPACK Extractor folder (provided, includes my update)

 Install Python 3.10.6

Run the installer.

Make sure to check “Add Python to PATH”.

Verify installation by opening CMD and running:

py -0


Python 3.10 should appear in the list.

 Install LZO Module

Open CMD.

Go to your Downloads folder (or wherever you saved the .whl):

cd %USERPROFILE%\Downloads


Verify the .whl file exists:

dir python_lzo-1.15-cp310-cp310-win_amd64.whl


Install LZO for Python 3.10:

py -3.10 -m pip install python_lzo-1.15-cp310-cp310-win_amd64.whl

 Test LZO Installation

Open Python 3.10 shell:

py -3.10


Run:

import lzo
print("LZO OK on Python 3.10")


If it prints LZO OK on Python 3.10, everything is good 

 Run PCPACK Extractor

Extract the PCPACK Extractor folder into Downloads or a location of your choice.

Open CMD in that folder.

Run:

py -3.10 PCPACK_Extractor.py


The script will ask for the path to the folder you want to extract.

My latest update to the WOS tools is included here.

 Temporary .BAT Launcher (Optional)

You can create a temporary .bat launcher to simplify running the extractor

we are 3 in this project i will provide link to thier tools and special thanks to them  haruse for addon blender and texture vieiwer (https://github.com/Spider-Man-Web-of-Shadows-Tools
GitHub)

and  (https://github.com/kirbystealer)
