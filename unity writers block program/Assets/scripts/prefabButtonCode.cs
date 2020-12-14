using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class prefabButtonCode : MonoBehaviour
{
    public promptLoader loaderCode;

    public void fileNamePass()
    {
        loaderCode.loadPrompt(this.GetComponentInChildren<Text>().text);
    }
}
