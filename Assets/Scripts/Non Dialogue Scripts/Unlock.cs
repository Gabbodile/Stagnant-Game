using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Unlock : GameBehaviour<Unlock>
{
    public CheckList _CL1; // refrences the checklist
    public GameObject Lock;//The Object you want to activate

    //Select how many Locks you want
    public bool oneLock;
    public bool twoLock;
    public bool threeLock;
    public bool fourLock;

    //The Locks
    private bool Lock1;
    private bool Lock2;
    private bool Lock3;
    private bool Lock4;

    //Reffrences the Events in the Checklist
    public int key1, key2, key3, key4;

    public void UnlockCheck() //Directs the program depending on number of locks
    {
        if (oneLock == true) // goes to one lock
        {
            UnlockThing1();
        }
        if (twoLock == true) //goes to two lock
        {
            UnlockThing2();
        }
        if (threeLock == true) // goes to three lock
        {
            UnlockThing3();
        }
        if (fourLock == true) // goes to four lock
        {
            UnlockThing4();
        }
    }

    public void UnlockThing1()
    {
        if (_CL1.structArray[key1].Check == true) // checks if event 1 has happened
        {
            Lock1 = true;// unlocks the first lock
        }
        if (Lock1 == true) //Checks if the locks are open
        {
            Lock.gameObject.SetActive(true);//activates the object
        }
    }

    public void UnlockThing2()
    {
        if (_CL1.structArray[key1].Check == true)// checks if event 1 has happened
        {
            Lock1 = true; //unlocks the first lock
        }

        if (_CL1.structArray[key2].Check == true)// checks if event 2 has happened
        {
            Lock2 = true;//unlocks the Second lock
        }

        if (Lock1 == true && Lock2 == true)//Checks if the locks are open
        {
            Lock.gameObject.SetActive(true);//activates the object
        }
    }

    public void UnlockThing3()
    {
        if (_CL1.structArray[key1].Check == true)// checks if event 1 has happened
        {
            Lock1 = true;//unlocks the first lock
        }

        if (_CL1.structArray[key2].Check == true)// checks if event 2 has happened
        {
            Lock2 = true;//unlocks the Second lock
        }
        if (_CL1.structArray[key3].Check == true)// checks if event 3 has happened
        {
            Lock3 = true;//unlocks the Third lock
        }


        if (Lock1 == true && Lock2 == true && Lock3 == true)//Checks if the locks are open
        {
            Lock.gameObject.SetActive(true);//activates the object
        }
    }

    public void UnlockThing4()
    {
        if (_CL1.structArray[key1].Check == true)// checks if event 1 has happened
        {
            Lock1 = true;//unlocks the first lock
        }

        if (_CL1.structArray[key2].Check == true)// checks if event 2 has happened
        {
            Lock2 = true;//unlocks the Second lock
        }
        if (_CL1.structArray[key3].Check == true)// checks if event 3 has happened
        {
            Lock3 = true;//unlocks the third lock
        }
        if (_CL1.structArray[key4].Check == true)// checks if event 4 has happened
        {
            Lock4 = true;//unlocks the fourth lock
        }

        if (Lock1 == true && Lock2 == true && Lock3 == true && Lock4 == true)//Checks if the locks are open
        {
            Lock.gameObject.SetActive(true);//activates the object
        }
    }

}
