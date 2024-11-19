//Wikipedia: The regular paperfolding sequence, also known as the dragon curve sequence, is an infinite automatic sequence of 0s and 1s defined as the limit of inserting an alternating sequence of 1s and 0s around and between the terms of the previous sequence:

//1

//1 1 0

//1 1 0 1 1 0 0

//1 1 0 1 1 0 0 1 1 1 0 0 1 0 0...

//Note how each intermediate sequence is a prefix of the next.

//Define a generator PaperFold that sequentially generates the values of this sequence:

//1 1 0 1 1 0 0 1 1 1 0 0 1 0 0 1 1 1 0 1 1 0 0 0 1 1 0 0 1 0 0...

//It will be tested for up to 1 000 000 values.

using System.Text;

var test1 = PaperFold();

foreach(var i in test1)
    Console.WriteLine(i);

static IEnumerable<int> PaperFold()
{
    string init = "1";

    int gapSize = 2;

    bool isOne = true;

    while (true)
    {
        var sb = new StringBuilder(new String('0', init.Length + gapSize));

        // odd index -> current digit
        int count = 0;

        for(int i = 1; i < sb.Length; i+=2)
        {
            sb[i] = init[count++];
        }

        // even index -> 1s & 0s
        for(int i = 0; i <= sb.Length; i+=2)
        {
            if (isOne)
            {
                sb[i] = '1';
                isOne = false;
            }
            else
            {
                sb[i] = '0';
                isOne = true;
            }
        }

        init = sb.ToString();

        // return

        if(init.Length > 3)
        {
            var temp = init.Substring(init.Length / 2);

            foreach(var each in temp)
            {
                yield return each - '0';
            }
        }
        else
        {
            foreach (var each in init)
            {
                yield return each - '0';
            }
        }

        gapSize *= 2;
    }
}

// QUESTIONS

// How do I insert 1s and 0s on each gap?
    // -- should I make them string?

// How to yiled return each digit after inserting?


// MY THOUGHS

// I think i'll create a string with length of current digit size & number of current gaps
// I'll then populate the string odd indexes for current digits and even for 1s and 0s
// I'll then convert each of them to int and yield return!