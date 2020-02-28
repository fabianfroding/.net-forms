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

        return 0;
    }

    // Maybe needs to take a file.
    public int countLines(string s)
    {

        return 0;
    }

}
