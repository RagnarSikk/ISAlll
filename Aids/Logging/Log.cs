﻿using System;

namespace isa3.Aids.Logging
{
    public static class Log
    {
        internal static ILogBook logBook;

        public static void Message(string message)
        {
            logBook?.WriteEntry(message);
        }

        public static void Exception(Exception e)
        {
            logBook?.WriteEntry(e);
        }
    }
}