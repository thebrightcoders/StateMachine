using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StateMachinePack
{
    public static class Validator
    {
        private const string VALID_CHARS = "1234567890_qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM ";
        private static List<char> ValidCharsList;

        static Validator()
        {
            StringToChar(VALID_CHARS);
        }

        internal static void ValidateLayerExistance(string iD, List<Layer> layers)
        {
            iD = iD.Trim();
            if (layers.Find(layerTofind => layerTofind.iD == iD) != null)
                throw new ArgumentException(string.Format("The Layer With ID = {0} Already Exists.", iD));
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
            return rawString.All(c => char.IsLetterOrDigit(c) || c == '_' || c == ' ');

            /*char[] rawStringChars = new char[rawString.Length];
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
            return true;*/
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

        internal static void ValidateStateExistance(string iD, Dictionary<string, State> states)
        {
            iD = iD.Trim();
            if (states.ContainsKey(iD))
                throw new Exception(string.Format("The State With ID = {0} Already Exists.", iD));
        }

        internal static void ValidateID(ref string iD)
        {
            iD = iD.Trim();
            //iD = (new Regex("\\s+")).Replace(iD, " ");
            if (IsStringEmpty(iD))
                throw new ArgumentException("The ID can't be empty!");
            if (!IsValidString(iD))
                throw new ArgumentException("The ID is not valid!");
        }
    }
}