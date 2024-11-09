// Dom and Sara want to play a game!
//     Game Rules
//
//     Both players are given the same string.
//     Both players have to make substrings using the letters of the string.
//     Dom has to make words starting with consonants.
//     Sara has to make words starting with vowels [AEIOU].
//     The game ends when both players have made all possible substrings.
//
//     Scoring
//     A player gets +1 point for each occurrence of the substring in the string.
//
//     For Example:
// String = BANANA
// Sara's vowel beginning word = ANA
// Here, ANA occurs twice in BANANA. Hence, Sara will get 2 Points.
//
//     For better understanding, see the image below:
//
//     ┌──────────────┐
//     │ B A N A N A  │
//     └──────────────┘
// Dom (Wins)                              Sara
//                          
//     WORDS         SCORE                   WORDS         SCORE     
//     B             1                       A             3
// N             2                      AN             2
// BA             1                     ANA             2
// NA             2                    ANAN             1
// BAN             1                   ANANA             1
// NAN             1
// BANA             1
// NANA             1
// BANAN             1
// BANANA             1
//                  
// TOTAL            12                   TOTAl             9
//
// Your task is to determine the winner of the game and their score.
//
//     Return a string showing the winner's name and score, separated by a space on one line, or Draw if there is no winner
// Sample Output: Dom 12

Console.WriteLine(CountSubstringsGame("BANANA"));
Console.WriteLine(CountSubstringsGame("BAANANAS"));
Console.WriteLine(CountSubstringsGame("BANAASA"));

static string CountSubstringsGame(string word)
{
    var vowels = word.Where(e => "aeiouAEIOU".Contains(e)).ToArray();
    var consonants = word.Where(e => !"aeiouAEIOU".Contains(e)).ToArray();
    
    int domeScore = word.Select((e , i) => consonants.Contains(e) ? word.Substring(i).Count() : 0).Sum();
    int saraScore = word.Select((e, i) => vowels.Contains(e) ? word.Substring(i).Count() : 0).Sum();

    return domeScore > saraScore ? $"Dom {domeScore}" :
        domeScore < saraScore ? $"Sara {saraScore}" :
        "Draw";
}