using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;
    private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1,corridor_0, stairs_0, stairs_1, stairs_2, courtyard, floor, corridor_1, corridor_2, corridor_3, closet_door, in_closet};
    private States myState;
	// Use this for initialization
	void Start () {
        myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
        print(myState);
        if      (myState == States.cell)            {cell();}
        else if (myState == States.sheets_0)        {sheets_0();}
        else if (myState == States.lock_0)          {lock_0();}
        else if (myState == States.mirror)          {mirror();}
        else if (myState == States.cell_mirror)     {cell_mirror();}
        else if (myState == States.sheets_1)        {sheets_1();}
        else if (myState == States.lock_1)          {lock_1();}
        else if (myState == States.corridor_0)      {corridor_0();}
        else if (myState == States.stairs_0)        { stairs_0(); }
        else if (myState == States.stairs_1)        { stairs_1(); }
        else if (myState == States.stairs_2)        { stairs_2(); }
        //else if (myState == States.courtyard)       { courtyard(); }
        //else if (myState == States.corridor_1)      { corridor_1(); }
        //else if (myState == States.corridor_2)      { corridor_2(); }
        //else if (myState == States.corridor_3)      { corridor_3(); }
        //else if (myState == States.closet_door)     { closet_door(); }
        //else if (myState == States.in_closet)       { in_closet(); }

    }


    void stairs_2()
    {
        text.text = "You are walking up the stairs towards the outside light. You realise it's not break time, and you'll be caught immeditaley.\n\n" +
            "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_2;
        }
    }
    void stairs_1()
    {
        text.text = "You are walking up the stairs towards the outside light. You realise it's not break time, and you'll be caught immeditaley.\n\n" +
            "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_1;
        }
    }

    void stairs_0()
    {
        text.text = "You are walking up the stairs towards the outside light. You realise it's not break time, and you'll be caught immeditaley.\n\n" +
            "Press R to Return to the coridor";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_0;
        }
    }

    void cell(){
        text.text = "You ara in prison cell, and you want to escape. There are aome drity sheets on the bed, a mirror on the wall, and the door" +
            "is locked from the outside.\n\n Press S to view Sheets, M to view Mirror and L to view Lock";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_0;
        } else if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.mirror;
        }else if (Input.GetKeyDown(KeyCode.L)){ 
            myState = States.lock_0;
        }    
    }

    void sheets_0()
    {
        text.text = "You can't belive you sleep in these things. Surely it's time somebody changed them. the pleasures of prison life I guess!\n\n"+
            "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void lock_0()
    {
        text.text = "This is on of those button locks. You have no idea what combinaton is. You wish you could somehow see where the dirty fingerprints" +
            " were, maybe that would help.\n\n Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }


    void mirror()
    {
        text.text = "You found key pre F to go forward";
        if (Input.GetKeyDown(KeyCode.F))
        {
            myState = States.cell_mirror;
        }else if(Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void cell_mirror()
    {
        text.text = "Wow so close to exit.\n\n Press S to se sheets or press L to se lock";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_1;
        }else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_1;
        }else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.mirror;
        }    
    }

    void sheets_1()
    {
        text.text = "So ugly sheets but you found key try to find out the door\n\n Press R to return";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
    }

    void lock_1()
    {
        text.text = "OMG you found the door and you have a KEY try to unlock the door!!!\n\n Press U to unlock the door or you can give up and go to begining by pressing B";
        if (Input.GetKeyDown(KeyCode.U))
        {
            myState = States.corridor_0;
        }else if (Input.GetKeyDown(KeyCode.B))
        {
            myState = States.cell;
        }
    }

    void corridor_0()
    {
        text.text = "You are in a corridor.\n\n Press R to retry the Game";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }
}
