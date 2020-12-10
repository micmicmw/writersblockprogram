using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldcode : MonoBehaviour
{
    public GameObject homepage;
    public GameObject themespage;

    public string detail = "empty";
    
    void Start()
    {
        homepage.active = true;
        themespage.active = false;
    }
    public void themepageactivation()
    {
        homepage.active = false;
        themespage.active = true;
    }
    public void homepageactivation()
    {
        homepage.active = true;
        themespage.active = false;
    }
    public void detailSetbasic()
    {
        detail = "basic";
    }
    public void detailSetminor()
    {
        detail = "minor";
    }
    public void detailSetdetailed()
    {
        detail = "detailed";
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

}
