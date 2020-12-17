using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Superhumans : MonoBehaviour
{
    // 2. physical description: Ethnicity, size: add in a ratio so that normal height gets priority, male/female, age: generic ex toddler, teenager
    // 1. power theme: ex - darkness, earth, mental, illusion, water, ice, fire, air, death, life, nature, metal, teleportation, body augmentation
    // 2. characteristic themes- we will have each characteristic be on a true and false value- ex: rich poor or stupid intellegent.
    // 2. body type: sickly, average, slim, thick, obese, body builder, curvy
    // 1. alignment: lawful- chaotic, good to evil
    // 3. important ideas: money, protecting my people, revenge, power, love, history, control, good vs evil, preservation/destruction, science, religion, advancements in a field,
    // 3. group status- lone wolf, group leader, second in command, minion, middle management, situational.


    public worldcode mainCode;
    public lists listSelector;
    public GameObject description;
    
    public void createPrompt()
    {
        description.GetComponent<TextMeshProUGUI>().text = "";
        int detail = mainCode.detailFunctionselector();
        // get depth
        promptCreation(detail);
        // pump depth choice into a function that will choose from a list of diffrent aspects for the character
    }

    public void promptCreation(int detail)
    {
        string age = "empty";
        string bodytype = "empty";
        if(detail >= 1)
        {
            description.GetComponent<TextMeshProUGUI>().text += "Power: " + listSelector.chooseFromlist("power") + "\n";
            description.GetComponent<TextMeshProUGUI>().text += "Alignment: " + listSelector.chooseFromlist("alignment") + "\n";
        }
        if(detail >= 2)
        {
            // physical description
            description.GetComponent<TextMeshProUGUI>().text += "Physical Description \n";
            description.GetComponent<TextMeshProUGUI>().text += "ethnicity: " + listSelector.chooseFromlist("ethnicity") + "\n";
            description.GetComponent<TextMeshProUGUI>().text += "size: " +listSelector.chooseFromlist("size") + "\n";
            age = listSelector.chooseFromlist("age");
            description.GetComponent<TextMeshProUGUI>().text += "age: " + age + "\n";
            description.GetComponent<TextMeshProUGUI>().text += "sex: " + listSelector.chooseFromlist("sex") + "\n";
            // characteristic themes
            description.GetComponent<TextMeshProUGUI>().text += "Character Characteristics \n";
            description.GetComponent<TextMeshProUGUI>().text += "    " + listSelector.chooseFromlist("characteristics") + "\n";
            description.GetComponent<TextMeshProUGUI>().text += "    " + listSelector.chooseFromlist("characteristics") + "\n";


            // I added this code and made it so bodytype and age are saved because I dont want a thick or curvy child character for obvious reasons.
            if(age == "child")
            {
                do
                {
                    bodytype = listSelector.chooseFromlist("bodytype");
                } while (bodytype == "curvy" || bodytype == "thick");
            }
            description.GetComponent<TextMeshProUGUI>().text += "Body Type: " + bodytype + "\n";

        }
        if(detail >= 3)
        {
            // importaint ideas
            description.GetComponent<TextMeshProUGUI>().text += "Important Concepts to the character: \n";
            description.GetComponent<TextMeshProUGUI>().text += "    " +listSelector.chooseFromlist("importantIdeas") + "\n";
            description.GetComponent<TextMeshProUGUI>().text += "    " +listSelector.chooseFromlist("importantIdeas") + "\n";

            // group status
            description.GetComponent<TextMeshProUGUI>().text += "Place in Orginizations: " + listSelector.chooseFromlist("groupstatus") + "\n";
        }
    }
}
