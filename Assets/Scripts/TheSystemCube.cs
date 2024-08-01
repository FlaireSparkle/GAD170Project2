using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TheSystemCube : MonoBehaviour
{
    #region variables

    public string murderTime = "";
    
    #region Player input
    public bool spaceToContinue = false;
    public bool decisionTime = false;
    public bool playerPrompt = false;
    #endregion
    
    #region Applicant variables
    //gameObject using the applicantCapsualPrefab (drag this to the Script)
    public GameObject applicantPrefab;
    public Applicant currentApplicant;
    //list that stores crew 
    public List<Applicant> theCrew = new List<Applicant> { };
    #endregion

    #region for fun
    public int totalApplicants = 0;
    public int piratesAvoidedCount = 0;
    public int pirateIncedentCount = 0;
    #endregion

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        //Run new game sequence.
        NewGame();
        






        Debug.Log("press space to continue");
    }
    /// <summary>
    /// public void contains Keys for testing 
    /// </summary>
    public void Update()
    {
        if ((playerPrompt == true) && (spaceToContinue == true))
        {
            Debug.Log("Press space bar to continue.");
            playerPrompt = false;
        }
        if ((playerPrompt == true) && (decisionTime == true))
        {
            Debug.Log("Press D to Disgard or H to Hire.");
            playerPrompt = false;
        }

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
////if crew needed is different, update text
        //if (""(10 - theCrew.Count)!= (10 - theCrew.Count))
        //{
        //    //update text here
        //}
        #region Hire the Applicant

        if ((decisionTime == true) && (Input.GetKeyDown(KeyCode.H)) && (currentApplicant!=null))
        {
            decisionTime = false;
            //the applicant is a pirate
            if (currentApplicant.GetIsPirate == true)
            {
                pirateIncedentCount++;
                //null check list is 1 or more
                if (theCrew.Count >= 1)
                {
                    // randomly select a number and change murderTime string to that number’s word from crewHobby list
                    murderTime = theCrew[Random.Range(0, (theCrew.Count - 1))].GetHobby;
                    //run for each loop that goes through the crewHobbys list in (uses a reducing list number for referencenumber) and DESTROYS all Applicant prefabs that have the hobby and remove them from the list (create a temp link)
                    for (int i = theCrew.Count - 1; i >= 0; i--)
                    {
                        Applicant applicant = theCrew[i];
                        //check if hobby = MurderTime
                        if (murderTime == (applicant.GetHobby))
                        {
                            //remove applicant from list
                            theCrew.Remove(applicant);
                            //destroy this applicant
                            Destroy(applicant.gameObject);
                        }
                    }
                    //change text to read :You have Hired “currentapplicantsName”.  They have killed and looted all members in the “murderTime” group. You now need “(10 - current number of crewMembers)”
                    Debug.Log("You have hired " + currentApplicant.GetName + ". They have killed and looted all members in the " + murderTime + " group. You now need " + (10 - theCrew.Count) + " crew members.");
                    //rest murdertime string
                    murderTime = "";
                }
                //else (null check list is NOT 1 or more)
                else if (theCrew.Count < 1)
                { 
                    //change text to read :You have Hired “currentapplicantsName”. They realised there was nothing interesting to do and left your crew. You now need “(10 - current number of crewMembers)”
                    Debug.Log("You have hired " + currentApplicant.GetName + ". They realised there was nothing interesting to do and left your crew. You now need " + (10 - theCrew.Count) + " crew members.");
                    
                }
                
                //destroy currentApplicant 
                Destroy(currentApplicant.gameObject);
                spaceToContinue = true;
                playerPrompt = true;
                return;
            }
            //the applicant is a normal crew member
            else if (currentApplicant.GetIsPirate == false)
            {
                Debug.Log("You have hired " + currentApplicant.GetName + ".");
                //add to theCrew (set is crew = true within the applicant's script)
                currentApplicant.isCrew = true;
                //add to the crew list
                theCrew.Add(currentApplicant);
               
                //check if you have 10 crew if yes you win (if no continue)
               if ((theCrew.Count) >= 10)
               {
                   YouWin();
                   return;
               }
                if ((theCrew.Count) < 10)
                {
                 RunNewApplicant();
                 return;
                }
            }

            
           
        }
        #endregion
        
            
        #region Disgard the Applicant
            //discard that application
            if ((decisionTime == true) && (Input.GetKeyDown(KeyCode.D)) && (currentApplicant != null))
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

    public void NewGame()
    {

        #region reset variables
        murderTime = "";
        spaceToContinue = false;
        decisionTime = false;
        //theCrew = ([]);
        if (theCrew.Count != null)
        { 
            for (int i = theCrew.Count - 1; i >= 0; i--)
            {
                Applicant applicant = theCrew[i];
                //remove applicant from list
                theCrew.Remove(applicant);
                //destroy this applicant
                Destroy(applicant.gameObject);
            
            }
        }
        totalApplicants = 0;
        piratesAvoidedCount = 0;
        pirateIncedentCount = 0;
        #endregion
        //this includes instructions and goal on the main text.
        Debug.Log("You are the captian of a ship");
        Debug.Log("You are almost ready to set off on your next adventure, the only thing stopping you is your lack of crew. You have narrowed down the applicants to those who meet the job requirements.");
        //turn on continue button.
        spaceToContinue = true;
        playerPrompt = true;
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
        
 //ActivateHireingModeUI(currentApplicant.GetName);
        Debug.Log("The applicant's name is " + currentApplicant.GetName);
        Debug.Log("Their favourite hobby is " + currentApplicant.GetHobby);
        totalApplicants ++;
        decisionTime = true;
        playerPrompt = true;
    }
    public void YouWin()
    {
        Debug.Log("Win conditions Met but code not written yet");
    }
}
