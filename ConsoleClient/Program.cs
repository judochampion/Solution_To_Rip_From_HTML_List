// See https://aka.ms/new-console-template for more information

using System.Text;

string OUTPUT_DIRECTORY_PATH = @"..\..\Output";
string OUTPUT_PATH_TO_CSV_FILE = @$"{OUTPUT_DIRECTORY_PATH}\SongList.csv";

Console.WriteLine("Hello, World!");

var lovList_Of_Songs = List_Ripper.List_Ripper.Rip_List();
Directory.CreateDirectory(OUTPUT_DIRECTORY_PATH);
File.WriteAllText(OUTPUT_PATH_TO_CSV_FILE, String.Join('\n', lovList_Of_Songs), Encoding.Unicode);

Console.WriteLine($"Wrote a new file with all evergreens to '{OUTPUT_PATH_TO_CSV_FILE}'.");
Console.Read();