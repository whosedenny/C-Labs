using System;
using lb6_extension;

namespace lb6;
class Program
{
    static void Main(string[] args)
    {
        Reverse reverse = new Reverse("abcd");

        reverse.Processing(164694);
    }
}

public class Reverse
{
    public string Sentence { get; set; }
    public Reverse(string sentence)
    {
        Sentence = sentence;
    }

    public string ReverseSentence()
    {
        return Sentence.Reverse().ToString();
    }
}