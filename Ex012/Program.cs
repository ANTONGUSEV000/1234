﻿
// vid 4
string Method4 (int count, string text)
{
    int i = 0;
    string result = string.Empty;
    while(i< count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10,"010100100101000010101011000110001");
System.Console.WriteLine(res);