using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class promptLoader : MonoBehaviour
{
    public GameObject prefabLoadButton;
    public GameObject promptList;
    public GameObject promptText;
    public worldcode mainCode;
    private string path = "Assets/promptfiles";
    // Start is called before the first frame update
    void Start()
    {
        // checks to see if the file we need to store at is made if not make one if its there do nothing
        
        if (!File.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        //getPrompts();
    }
    public void loadPrompt(string filename)
    {
        // open filename and have the text from promptText be the full text of filename
        mainCode.promptpageactivation();
        StreamReader reader = new StreamReader(path+ "/" + filename);
        promptText.GetComponent<TextMeshProUGUI>().text = reader.ReadToEnd();
        reader.Close();
    }
    public void getPrompts()
    {

        foreach (Transform child in GameObject.Find("SavedPromptsList").transform)
        {
            Destroy(child.gameObject);
        }
        string[] fileEntries = Directory.GetFiles(path);
        //Debug.Log("The length is " +fileEntries.Length);
        for(int i=0; i< fileEntries.Length; i++)
        {
            // had to make a filter for those pesky .meta files
            if (!fileEntries[i].Contains(".meta"))
            {
                GameObject button = Instantiate(prefabLoadButton, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                button.transform.parent = GameObject.Find("SavedPromptsList").transform;
                string strippedName = Path.GetFileNameWithoutExtension(fileEntries[i]);
                button.GetComponentInChildren<Text>().text = strippedName;
                button.GetComponent<Button>().onClick.AddListener(() => { loadPrompt(strippedName + ".txt"); });
            }
        }
    }
    public void savePrompt()
    {
        // saves a prompt with the chosen name
    }




}
