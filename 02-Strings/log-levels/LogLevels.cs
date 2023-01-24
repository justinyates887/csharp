using System;

static class LogLine
{

    /*
    This is not my solution.

    First, I tried using a Regex.Remove selector on logLine. This resulted in a scope error; Could not be used without a static reference.
    After attempting to resolve the error to no avail, I considered using a substring() method to split the error type from the method. This ended
    up being quite a few lines of code, which is not optimal. I decided to look for help in another's solution, hoping I would learn the most optimal way
    to write these methods. Below, I will explain what the code does.
    */

    public static string Message(string logLine) =>
        logLine[(logLine.IndexOf(':') + 1)..].Trim();

        /*
        This solution takes logLine and finds the position of the char ':'
        It then adds 1 to the index position, indicating the starting point of the desired return string
        The .. is a range operator, which allows us to select the starting and ending index for our selection. In this case, the desired return message.
        Finally, we call the .Trim() method on the selection to remove whitespace, if any.
        */

    public static string LogLevel(string logLine) =>
        logLine[1..logLine.IndexOf(']')].ToLower();

        /*
        We use a similar strategy for this return. We begin our range selector at index 1, and query to the char ']'.
        We are specifically looking for the type of log in this method, therefore the message is not needed.
        Finally, as per parameters, we call the ToLower() method to set the string to lowercase.
        */

    public static string Reformat(string logLine) =>
        $"{Message(logLine)} ({LogLevel(logLine)})";

        /*
        Here, we invoke our other two child methods return values in order to concat a return string with the values.
        */
}

