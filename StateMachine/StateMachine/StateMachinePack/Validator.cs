using System;
using System.Collections.Generic;

namespace StateMachinePack
{
    public class Validator
    {
        private const string VALID_CHARS = "1234567890_qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
        private static List<char> ValidCharsList;
        public Validator()
        {
            stringToChar(VALID_CHARS);
        }
        private void stringToChar(string rawString)
        {
            ValidCharsList = new List<char>(rawString.ToCharArray());
        }

        public bool isStringEmpty(string rawString)
        {
            return rawString.Trim() == "";
        }

        public bool isValidString(string rawString)
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

        public bool isValidIndexInLayersList(int index, List<Layer> list)
        {
            if (list != null) 
            {
                if (index >= 0 && index < list.Count)
                {
                    return true;
                }

                return true;
            }
            throw new Exception("The passed List Object is empty");
        }

        public bool isNullString(string rawString)
        {
            return rawString == null;
        }

    }
}