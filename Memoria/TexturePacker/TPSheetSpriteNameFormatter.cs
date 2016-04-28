﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Memoria.TexturePackerLoader
{
    public static class TPSheetSpriteNameFormatter
    {
        private static readonly KeyValuePair<string, TextReplacement>[] EscapeMap;
        private static readonly KeyValuePair<string, TextReplacement>[] UnescapeMap;

        static TPSheetSpriteNameFormatter()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>(4)
            {
                {"%", "%25"},
                {"#", "%23"},
                {":", "%3A"},
                {";", "%3B"},
            };

            EscapeMap = dic.Select(p => new KeyValuePair<string, TextReplacement>(p.Key, p.Value)).ToArray();
            UnescapeMap = dic.Select(p => new KeyValuePair<string, TextReplacement>(p.Value, p.Key)).ToArray();
        }

        public static String EscapeSpecialChars(String name)
        {
            return name.ReplaceAll(EscapeMap);
        }

        public static String UnescapeSpecialChars(String name)
        {
            return name.ReplaceAll(UnescapeMap);
        }
    }
}