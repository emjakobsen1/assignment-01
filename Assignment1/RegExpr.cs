namespace Assignment1;
using System.Text.RegularExpressions;

public static class RegExpr
{
    public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
    {
        using (var enumerator = lines.GetEnumerator())
            while (enumerator.MoveNext())
            {
                var line = enumerator.Current;
                foreach (Match m in Regex.Matches(line, @"\b[a-zA-Z0-9]+"))
                {
                    yield return m.ToString();
                }
            }
    }

    public static IEnumerable<(int width, int height)> Resolution(IEnumerable<string> resolutions)
    {
        foreach (string line in resolutions)
        {
            string pattern = @"(?<beforeX>\d+)x(?<afterX>\d+)";
            foreach (Match m in Regex.Matches(line, pattern))
            {
                int x = Int32.Parse(m.Groups["beforeX"].Value);
                int y = Int32.Parse(m.Groups["afterX"].Value);
                yield return (x, y);
            }
        }
    }

    public static IEnumerable<string> InnerText(string html, string tag)
    {
        string pattern = $@"(?<=<{tag}\\s*[^><]*>\\s*)[^<>]*";
        // (?<tag></a>|/>)
        foreach (Match m in Regex.Matches(html, pattern))
        {
            yield return m.ToString();
        }
    }
    //public static IEnumerable<(Uri url, string title)> Urls(string html){}
}
