using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class FileHandler
{
    public FileHandler()
    {
    }

    public void saveFile(string fileName, string text)
    {
        System.IO.StreamWriter sw = new System.IO.StreamWriter(fileName);
        sw.Write(text);
        sw.Close();
    }

}
