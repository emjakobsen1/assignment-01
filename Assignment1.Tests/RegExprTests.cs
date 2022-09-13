namespace Assignment1.Tests;
using Xunit;

public class RegExprTests
{
    [Fact]
    public void SplitLine_Given_List_Of_Strings_Return_List_Of_Words()
    {
        List<string> list = new List<string>
        {
            "Elisabeth, du bar os paa din ryg",
            "paa skuldrene af dig stod vi",
            "Endnu engang maa livet gaa",
            "mod Europas fald",
            "paa maa og faa"
        };
        var output = RegExpr.SplitLine(list);

        List<string> words = new List<string>
        {
            "Elisabeth",
            "du",
            "bar",
            "os",
            "paa",
            "din",
            "ryg",
            "paa",
            "skuldrene",
            "af",
            "dig",
            "stod",
            "vi",
            "Endnu",
            "engang",
            "maa",
            "livet",
            "gaa",
            "mod",
            "Europas",
            "fald",
            "paa",
            "maa",
            "og",
            "faa"
        };

        Assert.Equal(words, output);
    }

    [Fact]
    public void List_With_Resolutions_Returns_Tupled()
    {
        List<string> resolutions = new List<string> {"1920x1080", "1024x768, 800x600, 640x480", "320x200,", "320x240, 800x600", "1280x960"};

        IEnumerable<(int height, int width)> output = RegExpr.Resolution(resolutions);

        List<(int, int)> tuples = new List<(int, int)>
        {
            (1920, 1080),
            (1024, 768),
            (800, 600),
            (640, 480),
            (320, 200),
            (320, 240),
            (800, 600),
            (1280, 960)
        };
        Assert.Equal(tuples, output);
    }

    [Fact]
    public void InnerText_Given_HTML_a_Tag_Return_List()
    {
        string html =
            "<div><p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=\"https://en.wikipedia.org/wiki/Theoretical_computer_science\" title=\"Theoretical computer science\">theoretical computer science</a> and <a href=\"https://en.wikipedia.org/wiki/Formal_language\" title=\"Formal language\">formal language</a> theory, a sequence of <a href=\"https://en.wikipedia.org/wiki/Character_(computing)\" title=\"Character (computing)\">characters</a> that define a <i>search <a href=\"https://en.wikipedia.org/wiki/Pattern_matching\" title=\"Pattern matching\">pattern</a></i>. Usually this pattern is then used by <a href=\"https://en.wikipedia.org/wiki/String_searching_algorithm\" title=\"String searching algorithm\">string searching algorithms</a> for \"find\" or \"find and replace\" operations on <a href=\"https://en.wikipedia.org/wiki/String_(computer_science)\" title=\"String (computer science)\">strings</a>.</p></div>";
        var output = RegExpr.InnerText(html, "a");
        List<string> shouldBe = new List<string>
        {
            "theoretical computer science",
            "formal language",
            "characters",
            "pattern",
            "string searching algorithms",
            "strings"
        };
        Assert.Equal(shouldBe, output);
    }
    /*
    [Fact]
    public void InnerText_Given_HTML_a_Tag_Nested_Return_List()
    {
        string html =
           "<div><p>The phrase <i>regular expressions</i> (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing <u>patterns</u> that matching <em>text</em> need to conform to.</p></div>";
        var output = RegExpr.InnerText(html, "p");
        List<string> shouldBe = new List<string>
        {
            "The phrase regular expressions (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing patterns that matching text need to conform to."
        };
        Assert.Equal(shouldBe, output);
    }*/
}
