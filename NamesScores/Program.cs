//Names scores

var namesText = File.ReadAllText("p022_names.txt");
namesText = namesText.Replace("\"", "");

var names = namesText.Split(",").OrderBy(x => x).ToArray();
List<double> nameScores = new();
for (var i = 0; i < names.Length; i++)
{
    var letterVal = names[i].ToCharArray().Sum(GetCharValue);
    nameScores.Add(letterVal * (i + 1));
}

Console.WriteLine($"Sum of names Score : {nameScores.Sum()} ");
Console.ReadLine();

int GetCharValue(char character)
{
    character = character.ToString().ToLower()[0];
    return character switch
    {
        'a' => 1,
        'b' => 2,
        'c' => 3,
        'd' => 4,
        'e' => 5,
        'f' => 6,
        'g' => 7,
        'h' => 8,
        'i' => 9,
        'j' => 10,
        'k' => 11,
        'l' => 12,
        'm' => 13,
        'n' => 14,
        'o' => 15,
        'p' => 16,
        'q' => 17,
        'r' => 18,
        's' => 19,
        't' => 20,
        'u' => 21,
        'v' => 22,
        'w' => 23,
        'x' => 24,
        'y' => 25,
        'z' => 26,
        _ => 0
    };
}