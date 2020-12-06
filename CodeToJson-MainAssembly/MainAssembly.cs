using System;
using System.Reflection.Metadata.Ecma335;
using System.Net;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using MainAssemblyProg;

namespace MainAssemblyProg
{
    class MainAssembly
    {
        public static List<ProgramableProperties> ProgramableParts = new List<ProgramableProperties>();
        public static List<string> ProgramVariables = new List<string>();
        static void Main(string[] args)
        {
        Start:
            Console.WriteLine("Setup, Compile, or StartFresh?");
            var response = Console.ReadLine();
            if (response.ToLower() == "compile" || (response.Contains("c") && response.Contains("o") && response.Contains("m"))) 
            {
                var item = FindFile();
                var DecompCode = ScriptReader.ReadCSharp(item);
            }
            else if (response.ToLower() == "setup" || (response.Contains("s") && response.Contains("e") && response.Contains("t")))
            {
                var item = FindFile();
                if (item != null)
                {
                    GetFile:
                    Console.WriteLine("Json File Path:");
                    //string JsonFile = Console.ReadLine();
                    string JsonFile = @"C:\Users\Matthew\AppData\Local\RoboBuild\Saved\bots\.bot.Debug Bot\Debug Bot.schematic.json";
                    try
                    {
                        var FileContent = File.ReadAllText(JsonFile);
                        var firstLine = File.ReadAllLines(JsonFile)[0];
                        FileContent = FileContent.Replace(firstLine, "");
                        dynamic JsonContent = JsonConvert.DeserializeObject(FileContent);
                        var Json = SubItemsJson(JsonContent.parts);
                        RegisterProgramableItems(Json.Key, Json.Value);
                        ImportVariables(item);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e + "\nFile Read Error");
                        goto GetFile;
                    }
                }
                else return;
            }
            else
            {
                Console.WriteLine("Response Parse Error");
                goto Start;
            }
        }

        private const string startupOutline = " = ProgramableProperties.AddProperty((dynamic)JsonConvert.DeserializeObject(@\" //json here \"), Programables.NewPart(\"//full name\", \"default_name\"));";
        static void ImportVariables(string Script)
        {
            string source = Script;
            Script = File.ReadAllText(Script);
            if (Script.IndexOf("public void StartUp()") >=0)
            {
                int index1 = Script.IndexOf("// SETUP VAR HERE START")+23;
                int index2 = Script.IndexOf("// SETUP VAR HERE END");
                Script = Script.Replace(Script.Substring(index1, index2 - index1), "\n    ");
            }
            foreach (var item in ProgramableParts)
            {
                var part = item.ProgramablePart;
                var Initialize = "    ProgramableProperties " + string.Join("_", part.PartName, part.Id) + " = new ProgramableProperties();";
                Script = Script.Replace("// SETUP VAR HERE START", "// SETUP VAR HERE START" + Environment.NewLine + Initialize);
                //Debug.WriteLine(item.Properties.ToString());
            }
            File.WriteAllText(source, Script);
        }
        static void RegisterProgramableItems(List<string> parts, List<JObject> Jprop)
        {
            var index = 0;
            foreach (string part in parts)
            {
                if (Parts.GetPartName(part) != PartList.NONE)
                {
                    try { ProgramableParts.Add(ProgramableProperties.AddProperty(Jprop[index], Programables.NewPart(part))); } catch { }
                    List<JObject> itemsToRemove = new List<JObject>();
                    foreach (var item in Jprop) 
                    {
                        string content = item + "";
                        if (content.Length <= 0)
                        {
                            itemsToRemove.Add(item);
                        }
                        else
                        {
                            List<string> Properties = new List<string>();
                            List<string> PropertyValues = new List<string>();
                            foreach(var item0 in ((item as dynamic).values as JObject).Properties().Select(p => p.Name).ToList())
                            {
                                var ValueType = ((item as dynamic).values[item0] as JObject).Properties().ToList()[1];
                                var PropertyName = item0;
                                if (ValueType.Name == "float")
                                {
                                    PropertyValues.Add(ValueType.Value.ToString());
                                }
                                else if (ValueType.Name == "vector")
                                {
                                    PropertyValues.Add(ValueType.Value.ToString());
                                }
                                else if (ValueType.Name == "integer")
                                {
                                    PropertyValues.Add(ValueType.Value.ToString());
                                }
                                Properties.Add(PropertyName);
                            }
                            ObjectProperties.AddProperty(Properties, PropertyValues);
                        }
                    }
                    foreach (var item in itemsToRemove)
                    {
                        Jprop.Remove(item);
                    }
                }
                index++;
            }
            Console.WriteLine("{0} Programable Parts out {1} total parts detected.", ProgramableParts.Count, parts.Count);
        }
        public static void RegisterScriptVariables(string script)
        {
            Console.WriteLine("Reading Script...");
            string discard = script;
            while (discard.Contains("var"))
            {
                int start = discard.IndexOf("var");
                int end = discard.IndexOf(";");
                ProgramVariables.Add(discard.Substring(start, end - start));
                string variable = discard.Substring(start, end - start).Split("=")[1].Replace(" ", "");
                string variableName = discard.Substring(start, end - start).Split("=")[0].Replace("var ", "").Replace(" ", "");
                discard = discard.Remove(start, (end - start) + 4);
                discard = discard.Replace(variableName, variable);
            }
            Console.WriteLine("{0} Variables Counted", ProgramVariables.Count);
        }
        static KeyValuePair<List<string>, List<JObject>> SubItemsJson(dynamic JsonContent)
        {
            List<JObject> Jlist = new List<JObject>();
            List<string> list = new List<string>();
            JObject obj = JsonContent as JObject;
            foreach (JProperty prop in obj.Properties())
            {
                Jlist.Add(JsonContent[prop.Name].properties as JObject);
                list.Add(prop.Name);
            }
            return new KeyValuePair<List<string>, List<JObject>>(list, Jlist);
        }
        static string FindFile()
        {
            foreach (string item in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory))
                if (item.Split("\\")[^1].Split(".")[0].ToLower() == "script")
                    return item;
            return null;
        }
    }
    class ScriptReader
    {
        public static string ReadCSharp(string File)
        {
            string UserScript = Format.FormatCSharp(System.IO.File.ReadAllText(File));
            while (UserScript.Contains("using"))
            {
                var start = UserScript.IndexOf("using");
                var end = UserScript.IndexOf(";");
                UserScript = UserScript.Remove(start, (end - start) + 1);
            }
            MainAssembly.RegisterScriptVariables(UserScript);
            return null;
        }
    }
    class Format 
    { 
        public static string FormatCSharp(string UserScript)
        {
            UserScript = UserScript.Replace("}", " } ");
            UserScript = UserScript.Replace("{", " { ");
            UserScript = UserScript.Replace("(", " ( ");
            UserScript = UserScript.Replace(")", " ) ");
            UserScript = UserScript.Replace("   ", "");
            UserScript = UserScript.Replace(Environment.NewLine, "");
            while (UserScript.Contains("  ")) { UserScript = UserScript.Replace("  ", " "); }
            UserScript = UserScript.Replace("{ ", Environment.NewLine + "{ " + Environment.NewLine);
            UserScript = UserScript.Replace("} ", "} " + Environment.NewLine);
            UserScript = UserScript.Replace("; ", "; " + Environment.NewLine);
            UserScript = UserScript.Replace(" public ", Environment.NewLine + "public ");
            UserScript = UserScript.Remove(UserScript.Length-3);
            while (UserScript.Contains("  ")) { UserScript = UserScript.Replace("  ", " "); }
            return UserScript;
        }
    }
}
