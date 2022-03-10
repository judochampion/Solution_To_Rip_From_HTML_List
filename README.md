# Solution_To_Rip_From_HTML_List
A small solution with a project where I read a list of songs from a webpage. 

I had a webpage with a list of 1000 evergreens that I wanted to store as a csv locally. But the songs where sorted in chunks of 100 behind a paged table. 

![Console app Result](https://github.com/judochampion/Solution_To_Rip_From_HTML_List/blob/master/Readme_Pictures/Original_Internet_Page.png?raw=true)

I saved the webpages locally and wrote a small library called "List_Ripper" to rip this list by using the Nuget Package **HtmlAgilityPack**. 

![Console app Result](https://github.com/judochampion/Solution_To_Rip_From_HTML_List/blob/master/Readme_Pictures/Class_Name_Nodes.png?raw=true)

Via a console app I looped through all files and stored them in a csv, after also HTMLDecoding the strings. 

![Console app Result](https://github.com/judochampion/Solution_To_Rip_From_HTML_List/blob/master/Readme_Pictures/Console_Result.png?raw=true)

The result is in a csv-file. 

![Console app Result](https://github.com/judochampion/Solution_To_Rip_From_HTML_List/blob/master/Readme_Pictures/Result_CSV.png?raw=true)
