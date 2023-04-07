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
    snake++;
else
    camel++;


// Denis = Penis
var final_string = "";
if (camel == 1)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (i == 0)
        {
            final_string += str[i].ToString().ToUpper();
            continue;
        }
        if (str[i] == '_')
            continue;

        if (str[i-1] == '_' && str[i] != '_')
            final_string += str[i].ToString().ToUpper();
        else
            final_string += str[i];
    }
}

else if (snake == 1)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (i == 0)
        {
            final_string += str[i].ToString().ToLower();
            continue;
        }

        if (str[i].ToString() == str[i].ToString().ToUpper())
            final_string += $"_{str[i].ToString().ToLower()}";
        else
            final_string += str[i];
    }
}
File.WriteAllText("output.txt", final_string);
//Console.Write(final_string);
// Console.WriteLine(final_string);