using System;

public static class LogAnalysis 
{

    public static string SubstringAfter(this string logLine, string delimiter){
        /*
        Implement the (static) LogAnalysis.SubstringAfter() extension method, that takes in some string delimiter and returns the substring after the delimiter.
        */
        return logLine[(logLine.IndexOf(delimiter) + 1)..];

    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type

        public static string SubstringBetween(this string logLine, string start, string end){
        /*
        Implement the (static) LogAnalysis.SubstringAfter() extension method, that takes in some string delimiter and returns the substring after the delimiter.
        */
        return logLine[(logLine.IndexOf(start) + logLine.IndexOf(end))..];

    }
    
    // TODO: define the 'Message()' extension method on the `string` type
        public static string Message(this string logLine){
        /*
        Implement the (static) LogAnalysis.SubstringAfter() extension method, that takes in some string delimiter and returns the substring after the delimiter.
        */
        return logLine;

    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
        public static string LogLevel(this string logLine){
        /*
        Implement the (static) LogAnalysis.SubstringAfter() extension method, that takes in some string delimiter and returns the substring after the delimiter.
        */
        return logLine;

    }
}