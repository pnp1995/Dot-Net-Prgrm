using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace ObjectOrientedPrograms.InventaryPrgm
{
    class InventaryUtility
    {
        public static bool ContainsCharacter(string username)
        {
            try
            {
                char[] usernameCharacter = username.ToCharArray();
                for (int i = 0; i < usernameCharacter.Length; i++)
                {
                    if (!char.IsLetterOrDigit(usernameCharacter[i]))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw new Exception(ex.Message);
            }
            return true;
        }
        public static bool ConatainsDigit(string username)
        {
            try
            {
                char[] useernameCharacter = username.ToCharArray();
                for (int i = 0; i < useernameCharacter.Length; i++)
                {
                    if (char.IsDigit(useernameCharacter[i]))
                    {
                        return true;
                    }
                    return false;
                }   
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return true;
        }
        public static bool CheckString(string name)
        {
            try
            {
                //// Remove all leading and trailing white space character from the current string object. 
                name = name.Trim();
                if (string.IsNullOrEmpty(name))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return true;
        }
        public static bool IsNumber(string input)
        {
            try
            {
                for(int i = 0;i<input.Length;i++)
                {
                    if (char.IsDigit(input[i]) == false)
                    {
                        return false;
                    }
                    return true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public static string pathData()
        {
            string path = @"C:\Users\admin\Desktop\BasicProgram\ObjectOrientedPrograms\ObjectOrientedPrograms\InventaryPrgm\json2.json";
            return path;
        }
    }
}
