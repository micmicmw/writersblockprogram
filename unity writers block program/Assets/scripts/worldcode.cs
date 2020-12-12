using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class worldcode : MonoBehaviour
{
    public GameObject homepage;
    public GameObject themespage;
    public GameObject inDepthpage;
    public GameObject promptPage;
    public GameObject depthindicator;

    public string detail = "empty";
    
    void Start()
    {
        homepage.active = true;
        themespage.active = false;
        inDepthpage.active = false;
        promptPage.active = false;

    }
    public void themepageactivation()
    {
        homepage.active = false;
        themespage.active = true;
        inDepthpage.active = false;
        promptPage.active = false;
    }
    public void homepageactivation()
    {
        homepage.active = true;
        themespage.active = false;
        inDepthpage.active = false;
        promptPage.active = false;
    }
    public void indepthpageactivation()
    {
        homepage.active = false;
        themespage.active = false;
        inDepthpage.active = true;
        promptPage.active = false;
    }
    public void promptpageactivation()
    {
        homepage.active = false;
        themespage.active = false;
        inDepthpage.active = false;
        promptPage.active = true;
    }
    public void detailSetbasic()
    {
        detail = "basic";
        depthindicator.GetComponent<TextMeshProUGUI>().text = "Detail Level: basic";
        Debug.Log(detail);
    }
    public void detailSetminor()
    {
        detail = "minor";
        depthindicator.GetComponent<TextMeshProUGUI>().text = "Detail Level: Detailed";
        Debug.Log(detail);
    }
    public void detailSetdetailed()
    {
        detail = "detailed";
        depthindicator.GetComponent<TextMeshProUGUI>().text = "Detail Level: Very Detailed";
        Debug.Log(detail);
    }

    public int detailFunctionselector()
    {
        if(detail == "basic")
        {
            return 1;
        }else if(detail == "minor")
        {
            return 2;
        }else if(detail == "detailed")
        {
            return 3;
        }
        else
        {
            Debug.Log("The detail was never set");
        }
        return 0;
    }
    public void exitProgram()
    {
        Application.Quit();
    }

}
