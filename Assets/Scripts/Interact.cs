using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interact : MonoBehaviour
{
    [SerializeField] string obName = null;//Empty string
    [SerializeField] GameObject dragObject = null;//Empty gameObject
    [SerializeField] GameObject dragObject1 = null;//Empty gameObject

    [SerializeField] public GameObject obObject = null;//Empty gameObject
    [SerializeField] GameObject obObject1 = null;//Empty gameObject
    //public Unlock unl;
    public GameManager GM;
    public CheckList CL;
    public LocksStorage LS;
    
    private bool interactPressed = false;
    private bool submitPressed = false;

    private static Interact instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Found more than one Input Manager in the scene.");
        }
        instance = this;
    }

    //public Events eventScript;
    public static Interact GetInstance()
    {
        return instance;
    }
   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//Mouse Input
        {
            RaycastHit2D Hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);//Casts Ray where the mouse is
            if (Hit.collider != null)//checks if youve hit something
            {
                obName = Hit.transform.name;//grabs the hit objects name and stores it in the empty string
                obObject = Hit.collider.gameObject;//sets the object
               
                if (Hit.collider.gameObject.tag == "Drag")//checks if the object can be dragged
                {
                    dragObject = Hit.collider.gameObject;//sets the object
                }
                if (Hit.collider.gameObject.tag == "EndNight")
                {
                    GM.LoopCalculator();
                }
                Actions(); //Checks for actions
                
                    
                
            }
            
        }
        if (Input.GetMouseButtonUp(0))//Mouse Input
        {
            dragObject = dragObject1;//Resets the Object
        }

        Vector3 mousePos = Input.mousePosition;//Sets up new Vector 3 that mimics the Mouse Position
        mousePos.z = Camera.main.nearClipPlane;//defaults the Z axis to stop disapearing objects
        dragObject.transform.position = Camera.main.ScreenToWorldPoint(mousePos);//Sets the Object to the Mouse Position


    }

    private void Actions()//Stores Actions
    {
       
        if (obObject.GetComponent<EventReporter>() != null)
        {
            obObject.GetComponent<EventReporter>().Interacted();//tells the object that it has been interacted with
            if (obObject.GetComponent<EventReporter>().usesEnergy == true)
            {
                CL.CalculatePoints();
                //obObject = obObject1;//Resets the Object
            }
                if (obObject.GetComponent<EventReporter>().isKey == true)
            {
                LS.CheckLocks(obObject);
                //obObject = obObject1;//Resets the Object
            }
            
        }
        if (obObject.GetComponent<NPC>() != null)
        {
            obObject.GetComponent<NPC>().Dialogue();//activates the Npc scripts
            obObject = obObject1;//Resets the Object
        }
        if(obObject.GetComponent<Doors>() != null)
        {
            obObject.GetComponent<Doors>().OpenDoor();//activates the doors script
            obObject = obObject1;//Resets the Object
        }
        if (obObject.GetComponent<DestroyMe>() != null)
        {
            obObject.GetComponent<DestroyMe>().IhaveBeenDestroyed();//activates the Npc scripts
            obObject = obObject1;//Resets the Object
        }
        if (obObject.GetComponent<CollisionDestroy>() != null)
        {
            obObject.GetComponent<CollisionDestroy>().EnableLaundry();
            Debug.Log("LaundryEnabled2");
            obObject = obObject1;//Resets the Object
        }
    }

    
}
