using System;

public class StringHandler
{
	public StringHandler()
	{
	}

    public int countLetters(string s, bool includeSpaces)
    {
        int count = 0;
        if (includeSpaces)
        {
            count = s.Length;
        }
        else
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    count++;
                }
            }
        }
        return count;
    }

    public int countWords(string s)
    {
        int length = s.Length;
        int count = 0;
        try
        {
            // Enskild hantering av första karaktären eftersom vi börjar med att leta
            // efter mellanslag i loopen, så finns det en risk att vi missar denna.
            if (s[0] != ' ')
            {
                count++;
            }
            // Algoritm som varje gång den finner ett mellanslag, så skapar den en inre
            // loop.
            for (int i = 0; i < length; i++)
            {
                if (s[i] == ' ')
                {
                    // Den inre loopen fortsätter genom ytterligare mellanslag ända tills
                    // den hittar en bokstav (i.e. ett ord), varav den då ökar antal
                    // räknade ord och sätter index i till där j slutade, och index i
                    // till där j slutade.
                    for (int j = i; j < length; j++)
                    {
                        if (s[j] != ' ')
                        {
                            count++;
                            i = j;
                            j = length;
                        }
                    }
                }
            }
        }
        catch (IndexOutOfRangeException e)
        {
            System.Diagnostics.Debug.Write("Problem counting words: " + e.Message);
        }
        
        return count;
    }

    // Maybe needs to take a file.
    public int countLines(string s)
    {

        return 0;
    }

}
