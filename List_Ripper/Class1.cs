using HtmlAgilityPack;
using System.IO;
using System.Web;

namespace List_Ripper
{
    public class Class1
    {
        public bool Hello_World()
        {
            var test = Directory.GetDirectories(@"..\..\Project_1000_Klassiekers");
            foreach (var dir in test)
            {
                var lovFile = Directory.GetFiles(dir, "*", SearchOption.TopDirectoryOnly);
                var lovContent = File.ReadAllText(lovFile.First());
                var web = new HtmlDocument();
                web.LoadHtml(lovContent);
                var lovNode = web.DocumentNode.SelectNodes("//body");
            }
            return true;
            /*
            // Load
            var url = $"https://stats.swehockey.se/ScheduleAndResults/SearchResult?StatEntityId=12318&ByDate=false&byRound=true&ByRound=false&RoundFrom=1&RoundTo={i}";
            var web = new HtmlWeb();
            var doc = web.Load(url);
            var nodes = doc.DocumentNode.SelectNodes("//table[@class='tblContent']//td");

            var splits = nodes.ChunkBy(13);
            foreach (var node in splits)
            {
                var data = new RowData
                {
                    RK = node[0].InnerHtml.Trim(),
                    Team = HttpUtility.HtmlDecode(node[1].InnerHtml.Trim()),
                    GP = node[2].InnerHtml.Trim(),
                    W = node[3].InnerHtml.Trim(),
                    T = node[4].InnerHtml.Trim(),
                    L = node[5].InnerHtml.Trim(),
                    GFGA = node[6].InnerHtml.Trim(),
                    GD = node[7].InnerHtml.Trim(),
                    TP = node[8].InnerHtml.Trim(),
                    OTW = node[9].InnerHtml.Trim(),
                    OTL = node[10].InnerHtml.Trim(),
                    GWSW = node[11].InnerHtml.Trim(),
                    GWSL = node[12].InnerHtml.Trim(),
                };

                if (dict.TryGetValue(data.Team, out var team))
                {
                    team.Add(data);
                }
                else
                {
                    dict.Add(data.Team, new List<RowData> { data });
                }
            }*/
        }
    }

    public static class Ext
    {
        public static List<List<T>> ChunkBy<T>(this IEnumerable<T> source, int chunkSize)
        {
            return source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / chunkSize)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }
    }
}