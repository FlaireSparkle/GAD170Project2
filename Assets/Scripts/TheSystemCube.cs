using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TheSystemCube : MonoBehaviour
{
    #region variables
    #region for fun
    public int totalApplicants = 0;
    public int piratesAvoidedCount = 0;
    public int pirateIncedentCount = 0;
    #endregion
    #region Player input
    public bool spaceToContinue = false;
    public bool decisionTime = false;
    #endregion
    #region Applicant variables
    //gameObject using the applicantCapsualPrefab (drag this to the Script)
    public GameObject applicantPrefab;
    public Applicant currentApplicant;
    //lists that store crew & hobbys??
    public List<Applicant> allApplicants = new List<Applicant> ();
    public List<Applicant> theCrew = new List<Applicant> { };
    public string[] crewHobbys = new string[] { };
    #endregion

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        //Run new game sequence.
        
        //this includes instructions and goal on the main text.
       
        //turn on continue button.
        spaceToContinue = true;

        

        
      

        Debug.Log("press space to continue");
    }
    /// <summary>
    /// public void contains Keys for testing 
    /// </summary>
    public void Update()
    {
        #region Space Key To Continue
        //space to continue if continue is true (and progression is someting??)
        if (spaceToContinue == true && (Input.GetKeyDown(KeyCode.Space)))
        {
            //turn off continue button
            spaceToContinue = false;
            //make a new Applicant. 
            RunNewApplicant();
        }
        #endregion

        #region Hire the Applicant

        if (decisionTime = true &&  (Input.GetKeyDown(KeyCode.H)))
        {
            decisionTime = false;
            if (currentApplicant.GetIsPirate == true)
            {
                Debug.Log("You have hired " + currentApplicant.GetName + ".");
                pirateIncedentCount++;
                //if isPirate true && null check list is 1 or more

                // randomly select a number and change murderTime string to that number’s word from crewHobby list

                //run for loop that goes through the crewHobbys list and DESTROYS all Applicant prefabs that have the hobby  (maybe add && isCrew = true so it 100% wont destroy the Possibilities.cs?)

                //destroy currentApplicant 

                //run updateCrewCount()

                //change text to read :You have Hired “currentapplicantsName”.  They have killed and looted all members in the “murderTime” group. You now need “(10 - current number of crewMembers)”

                //else If isPirate true && null check list is NOT 1 or more
                //destroy currentApplicant 
                //run updateCrewCount()
                //change text to read :You have Hired “currentapplicantsName”. They realised there was nothing interesting to do and left your crew. You now need “(10 - current number of crewMembers)”


            }
            else if (currentApplicant.GetIsPirate == false)
            {
                Debug.Log("You have hired " + currentApplicant.GetName + ".");
                //add to theCrew (set is crew = true within the applicant's script)
                currentApplicant.isCrew = true;
                //add to the crew list
                Applicant[] theCrew = FindObjectsOfType<Applicant>();
                //check if you have 10 crew if yes you win (if no continue)
                

            }
            RunNewApplicant();
            return;
        }
        #endregion

        #region Disgard the Applicant
        //discard that application
        if (decisionTime = true && (Input.GetKeyDown(KeyCode.D)))
        {
            decisionTime = false;
            Debug.Log("You have rejected " + currentApplicant.GetName + ".");
            if (currentApplicant.GetIsPirate = true)
            { 
                piratesAvoidedCount++;
            }
            //add current applicant to trashCan or destroy them?
            Destroy(currentApplicant.gameObject);
            RunNewApplicant ();

        }
        #endregion

        #region Testing Key
        if (Input.GetKeyDown(KeyCode.P))
        {
            
            
        }
        #endregion
    }


    /// runs the setup of a new Applicant///
    public void RunNewApplicant()
    {
        //set applicant as "currentApplicant" while createing a new applicant (from the prefab)
        currentApplicant = Instantiate(applicantPrefab).GetComponent<Applicant>();
        //set prefab stats in that instance (which will first randomize stats in possibilitys)
        currentApplicant.StatCreation();
        //Set connected object's name the same as in the script
        currentApplicant.name = currentApplicant.GetName;

        //show CurrentApplicant's name and hobby to player on the UI

        //tell the buttons they are useable by setting decision time bool = true
        decisionTime = true;
        Debug.Log("The applicant's name is " + currentApplicant.GetName);
        Debug.Log("Their favourite hobby is " + currentApplicant.GetHobby);
        totalApplicants ++;
    }
}
