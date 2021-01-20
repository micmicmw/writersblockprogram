using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine;

public class UtilityCode : MonoBehaviour
{   
    // takes a raw file and scrubs it into a form that can be turned into a array list with a copy and paste
    public void textFIleScrubber()
    {
        string readpath = @"D:\Users\Mic\unity projects\writersblockprogram\unity writers block program\Assets\Rawlists\lastNames.txt";
        string writepath = @"D:\Users\Mic\unity projects\writersblockprogram\unity writers block program\Assets\Rawlists\cleanedList.txt";

        StreamReader reader = new StreamReader(readpath);
        string file = reader.ReadToEnd();
        reader.Close();
       
        //char[] separators = new char[] { ' ', '.' };
        //string[] subs = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        StreamWriter writer = new StreamWriter(writepath, true);
        string[] scrubbedfile = file.Split('\n');
        //Debug.Log(scrubbedfile.Length);

        //s = s.TrimEnd(new char[] { '\r', '\n' });


        for (int i = 0; i < scrubbedfile.Length; i++)
        {
        }
        /*
        scrubbedfile[i] = scrubbedfile[i].Replace("	", "");
        //String line = strWithTabs.Replace("    ", "");
        //scrubbedfile[i] = scrubbedfile[i].Replace(" ", "");
        //scrubbedfile[i] = scrubbedfile[i].Remove('\n');

        //Debug.Log(scrubbedfile[i]);

        writer.Write(scrubbedfile[i]);
        string holder = "";
        for(int r = 0; r< scrubbedfile[i].Length; r++)
        {
            if (Char.IsLetter(scrubbedfile[i][r]))
            {
                holder += scrubbedfile[i][r];

            }
        }
        Debug.Log(holder);
        scrubbedfile[i] = holder;
        */
        
        writer.Write(scrubbedfile);    
        writer.Close();

    }
    // creates a text file that can be copied and pasted to create a arraylist.
    public void textFiletoArrayList()
    {
        // we need to make each pulled entry look like -> "entry", with the last one not having a comma
    }
}
