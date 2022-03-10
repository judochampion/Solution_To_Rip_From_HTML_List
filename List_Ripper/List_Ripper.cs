using Domain;
using HtmlAgilityPack;
using System.Web;

namespace List_Ripper;

public static class List_Ripper
{
    private const string PATH_TO_DIRECTORY = @"..\..\Project_1000_Klassiekers";
    private const string INTERESTING_DIV_CLASS_NAME = @"css-901oao";

    public static List<Evergreen> Rip_List()
    {
        var livNumber_Counter = 0;

        var lovReturn_List = new List<Evergreen>();
        var lovDirectories = Directory.GetDirectories(PATH_TO_DIRECTORY);
        foreach (var varlovDir in lovDirectories)
        {
            var lovFile = Directory.GetFiles(varlovDir, "*", SearchOption.TopDirectoryOnly);
            var lovContent = File.ReadAllText(lovFile.First());
            var web = new HtmlDocument();
            web.LoadHtml(lovContent);
            //Source: https://stackoverflow.com/questions/1604471/how-can-i-find-an-element-by-css-class-with-xpath
            var lovNode_List = web.DocumentNode.SelectNodes($"//body//div[contains(concat(' ', @class, ' '), ' {INTERESTING_DIV_CLASS_NAME} ')]");
            //The first 4 are irrelevant.
            var lovRelevant_Node_List = lovNode_List.Skip(4).ToList();

            int livMaxCount = lovRelevant_Node_List.Count() / 2;

            for (int i = 0; i < livMaxCount; i++)
            {
                lovReturn_List.Add(
                    new Evergreen()
                    {
                        Number = ++livNumber_Counter,
                        Artist = HttpUtility.HtmlDecode(lovRelevant_Node_List[i * 2].InnerText.Trim()),
                        Song = HttpUtility.HtmlDecode(lovRelevant_Node_List[i * 2 + 1].InnerText.Trim())
                    }
                );
            }
        }
        return lovReturn_List;
    }
}