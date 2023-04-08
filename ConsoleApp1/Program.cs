using System;
using System.Linq;
using System.Text;
using System.IO;


string str;
int snake = 0;
var camel = 0;

using (FileStream fstream = File.OpenRead("input.txt"))
{
    byte[] buffer = new byte[fstream.Length];
    await fstream.ReadAsync(buffer, 0, buffer.Length);
    str = Encoding.Default.GetString(buffer);
}


if (str[0].ToString() == str[0].ToString().ToUpper())
{
    snake++;
}
else
{
    camel++;
}
    

var finalString = "";

if (camel == 1)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (i == 0)
        {
            finalString += str[i].ToString().ToUpper();
            continue;
        }
        if (str[i] == '_')
            continue;

        if (str[i - 1] == '_' && str[i] != '_')
        {
            finalString += str[i].ToString().ToUpper();
        }
        else
        {
            finalString += str[i];
        }
    }
}

else if (snake == 1)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (i == 0)
        {
            finalString += str[i].ToString().ToLower();
            continue;
        }

        if (str[i].ToString() == str[i].ToString().ToUpper())
        {
            finalString += $"_{str[i].ToString().ToLower()}";
        }
        else
        {
            finalString += str[i];
        }
    }
}

File.WriteAllText("output.txt", finalString);

// Console.WriteLine(final_string);