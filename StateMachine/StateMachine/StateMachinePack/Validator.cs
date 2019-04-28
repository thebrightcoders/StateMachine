using System;
using System.Collections.Generic;

namespace StateMachinePack
{
    public static class Validator
    {
        private const string VALID_CHARS = "1234567890_qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
        private static List<char> ValidCharsList;

        static Validator()
        {
            StringToChar(VALID_CHARS);
        }

        private static void StringToChar(string rawString)
        {
            ValidCharsList = new List<char>(rawString.ToCharArray());
        }

        public static bool IsStringEmpty(string rawString)
        {
            return rawString.Trim() == "";
        }

        public static bool IsValidString(string rawString)
        {
            char[] rawStringChars = new char[rawString.Length];
            if (rawString != null)
            {
                rawStringChars = rawString.ToCharArray();

                for (int i = 0; i < rawString.Length; i++)
                {
                    if (!ValidCharsList.Contains(rawStringChars[i]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool IsValidIndexInLayersList(int index, List<Layer> list)
        {
            if (list != null) 
            {
                if (index >= 0 && index < list.Count)
                {
                    return true;
                }

                return false;
            }
            throw new Exception("The passed List Object is empty");
        }

        public static bool IsNullString(string rawString)
        {
            return rawString == null;
        }

        public static void ValidateID(string iD)
        {

        }
    }
}