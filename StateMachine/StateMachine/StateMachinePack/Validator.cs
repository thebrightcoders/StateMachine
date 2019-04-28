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

        internal static void ValidateLayerExistance(string iD, List<Layer> layers)
        {
            iD = iD.Trim();
            if (layers.Find(layerTofind => layerTofind.iD == iD) != null)
                throw new Exception(string.Format("The Layer With ID = {0} Already Exists.", iD));
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
            if (index >= 0 && index < list.Count)
                return true;
            return false;
        }

        public static bool IsNullString(string rawString)
        {
            return rawString == null;
        }

        internal static void ValidateID(ref string iD)
        {
            iD = iD.Trim();
            if (IsStringEmpty(iD))
                throw new Exception("The ID can't be empty!");
            if (!IsValidString(iD))
                throw new Exception("The Id is not valid!");
        }
    }
}