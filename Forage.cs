using System;
using System.IO;

namespace Patern
{
    class Forage
    {
        string line;
        string buff;
        string desPath;
        string srcPath;
        string srcNew;

        StreamReader sr;

        StreamWriter sw,swNS;

        internal Forage()
        { }

        internal Forage(String s, String d)
        {
            desPath = d;
            srcPath = s;
            //temp file to store intermidiate data - This file contains the Source file data without blank spaces
            srcNew = "c:\\test1.txt";

            //Destroying the space 
            sr = new StreamReader(srcPath);
            spaceBust();
            sr.Close();

            //obtaining the file to be foraged
            sr = new StreamReader(srcNew);

            //Creating new empty text file
            sw = File.CreateText(desPath);
            sw.Write("");
            sw.Close();

            //open the text file in append mode
            sw = File.AppendText(desPath);
        }

        internal void destroy()
        {
            try
            {
                //Closing the Files
                sr.Close();
                sw.Close();
            }
            catch(Exception ex){
                System.Diagnostics.Debug.WriteLine("Destroyer Exception : " + ex);
            }
        }

        void spaceBust()
        {
            try
            {

                swNS = new StreamWriter(srcNew);
                while ((line = sr.ReadLine()) != null)
                {
                    //Replacing blank spaces with no value - deleting all blank areas
                    string tmp = line.Replace("\t", "").Replace(" ", "");
                    swNS.WriteLine(tmp);
                }
                //File Close
                swNS.Close();
                return;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("SpaceBuster Exception : " + ex);
            }
        }

        internal void obtain()
        {
            try
            {
                while ((line = sr.ReadLine()) != null)
                {
                    // Call Of Paylines Ghosts
                    if(line.Contains("<ComboSetList>")) paylines();

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == '>' && line.Substring(i + 1) != "")
                        {
                            i++;
                            //Foraging values between the tags - data between '>' and '<'
                            buff = "";
                            for (; line[i] != '<'; i++)
                            {
                                if (line[i] == ' ') continue;
                                buff += line[i];
                            }
                            sw.Write("    " + buff);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (line.Contains(""))
                        sw.WriteLine("");
                }
                System.Diagnostics.Debug.WriteLine("Success Obbt");
            }
            catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine("Obtainer Exception : " + ex);
            }
        }

        internal void paylines()
        {
            try
            {
                while ((line = sr.ReadLine()) != null)
                {                    

                    //return to weights and values obtainer
                    if (line.Contains("</ComboSetList>")) return;

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == '>' && line.Substring(i + 1) != "")
                        {
                            i++;

                            //Foraging values between the tags - data between '>' and '<'
                            buff = "";
                            for (; line[i] != '<'; i++)
                            {
                                if (line[i] == ' ') continue;
                                buff += line[i];
                            }
                            sw.Write("     " + buff);
                        }
                        else
                        {
                            continue;
                        }
                    }

                    //formatting - Creating New line
                    if (line.Contains("</PaylineCombo>") || line.Contains("</ScatterCombo>") || line.Contains("</CountScatterCombo>") || line.Contains("</AnywaysCombo>"))
                    {
                        sw.WriteLine("");
                    }
                    if(line.Contains("</PaylineComboSet>") || line.Contains("</ScatterComboSet>") || line.Contains("</CountScatterComboSet>") || line.Contains("</AnywaysComboSet>"))
                    {
                        sw.WriteLine("");
                    }
                    if (line.Contains("</Identifier>"))
                    {
                        sw.WriteLine("");
                        sw.WriteLine("");
                    }
                }

                System.Diagnostics.Debug.WriteLine("Success Pal");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Payline Exception : " + ex);
            }
        }
    }
}
