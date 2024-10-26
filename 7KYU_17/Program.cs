// Trilingual democracy
// Switzerland has four official languages: German, French, Italian, and Romansh.1

// When native speakers of one or more of these languages meet, they follow certain regulations to choose a language for the group.2 Here are the rules for groups of exactly three3 people:4

// When all three are native speakers of the same language, it also becomes their group's language.5a

// When two are native speakers of the same language, but the third person speaks a different language, all three will converse in the minority language.5b

// When native speakers of three different languages meet, they eschew these three languages and instead use the remaining of the four official languages.5c

// The languages are encoded by the letters D for Deutsch, F for Français, I for Italiano, and K for Rumantsch.6

// Your task is to write a function that takes a list of three languages and returns the language the group should use.7 8

// Examples:9

// The language for a group of three native French speakers is French: FFF → F

// A group of two native Italian speakers and a Romansh speaker converses in Romansh: IIK → K

// When three people meet whose native languages are German, French, and Romansh, the group language is Italian: DFK → I


// var asd = "iik".GroupBy(x => x).ToArray();
// Console.WriteLine(asd[0]);

Console.WriteLine(TrilingualDemocracy("FFF")); 
Console.WriteLine(TrilingualDemocracy("IIK")); 
Console.WriteLine(TrilingualDemocracy("DFK")); 

static char TrilingualDemocracy(string group)
{
    char res = 'i';
    
    var dict = new Dictionary<char, int>()
    {
        { 'D', 0 },
        { 'F', 0 },
        { 'I', 0 },
        { 'K', 0 },
    };

    foreach (var each in group)
    {
        if (!dict.ContainsKey(each)) 
            dict[each] += 1;
        else 
            dict[each] += 1;
    }

    foreach (var each in dict)
    {
        if (each.Value == 3)
        {
            res = each.Key;
            break;
        }
        
        if (each.Value == 2)
        {
            res = dict.First(e => e.Value == 1).Key;
            break;
        } 
        
        else 
            res = dict.First(e => e.Value == 0).Key;
    }

    return res;
}

// OTHER ANSWERS

static char _TrilingualDemocracy(string speakers)
{
    return (char)(speakers[0] ^ speakers[1] ^ speakers[2]);
}

Console.ReadLine();