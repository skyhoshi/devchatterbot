﻿namespace DevChatter.Bot.Core.Extensions
{
    public static class StringExtensions
    {
        public static string NoAt(this string src)
        {
            return src.StartsWith("@") ? src.Substring(1) : src;
        }
    }
}