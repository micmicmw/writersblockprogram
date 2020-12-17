using System.Collections;
using System.Collections.Generic;
using UnityEngine;




// 2. physical description: Ethnicity, size: add in a ratio so that normal height gets priority, male/female, age: generic ex toddler, teenager
// 1. power theme: ex - darkness, earth, mental, illusion, water, ice, fire, air, death, life, nature, metal, teleportation, body augmentation
// 2. characteristic themes- we will have each characteristic be on a true and false value- ex: rich poor or stupid intellegent.
// 2. body type: sickly, average, slim, thick, obese, body builder, curvy
// 1. alignment: lawful- chaotic, good to evil
// 3. important ideas: money, protecting my people, revenge, power, love, history, control, good vs evil, preservation/destruction, science, religion, advancements in a field,
// 3. group status- lone wolf, group leader, second in command, minion, middle management, situational.
public class lists : MonoBehaviour
{
    private ArrayList ethnicity = new ArrayList() { "white","black","asian","native american","indian"};
    private ArrayList size = new ArrayList() { "giant", "7 foot", "above average", "average", "average", "average", "below average", "five foot", "dwarf", "midget" };
    private ArrayList sex = new ArrayList() { "male","female"};
    private ArrayList age = new ArrayList() { "child","teenager","20-30's","40s-50's","senior citizen" };

    private ArrayList goodOrbad = new ArrayList() { " Does not have", " Has" };


    private ArrayList powerTheme = new ArrayList() { "darkness", "earth", "mental", "illusion", "water", "ice", "fire", "air", "death", "life", "nature",
                                                    "metal", "teleportation", "body augmentation" };




    private ArrayList characteristics = new ArrayList() { "wealth","intellegence","speed","strength","street smarts","dexterity","strength","charisma" };

    private ArrayList bodyType = new ArrayList() { "sickly", "average", "slim", "thick", "obese", "body builder", "curvy" };
    private ArrayList alignment = new ArrayList() { "Lawful Good","Lawful Neatral", "Lawful Evil","Neutral Good", "True Neautral", "Neautral Evil",
                                                    "Chaotic Good","Chaotic Neatral", "Chaotic Evil" };
    private ArrayList importantIdeas = new ArrayList() { "money", "protecting my people", "revenge", "power", "love", "history", "control",
                                                        "preservation / destruction", "science", "religion", "advancements in a field" };
    private ArrayList groupStatus = new ArrayList() { "lone wolf", "group leader", "second in command", "minion", "middle management", "situational" };

    public string chooseFromlist(string list)
    {
        
        int maxNum = -1;
        Random rnd = new Random();
        ArrayList chosenList;
        if(list == "ethnicity")
        {
            chosenList  = ethnicity;
        }else if(list == "size")
        {
            chosenList = size;
        }else if(list == "age")
        {
            chosenList = age;
        }else if(list == "power")
        {
            chosenList = powerTheme;
        }else if(list == "characteristics")
        {
            chosenList = characteristics;
        }else if(list == "bodytype")
        {
            chosenList = bodyType;
        }else if(list == "alignment")
        {
            chosenList = alignment;
        }else if(list == "importantIdeas")
        {
            chosenList = importantIdeas;
        }else if(list == "groupstatus")
        {
            chosenList = groupStatus;
        }else if(list == "sex")
        {
            chosenList = sex;
        }
        else
        {
            return "something wierd happened";
        }


        maxNum = chosenList.Count;
        int chosenIndex = (int)Random.Range(0, maxNum);
        
        return (string)chosenList[chosenIndex];
        
    }
}
