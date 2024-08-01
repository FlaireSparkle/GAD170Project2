using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Timeline;

/// <summary>
/// This is my GameManager it will hold information about the game and how it runs and it will hold player input
/// </summary>
public class GameManager : MonoBehaviour
{

    #region Variables

  //Create Variables
    //murderTime string
    private string murderTime;
    //Decision Time bool (shows if the player has been asked to H-hire or D-disgard an applicant)(activates and deactivates theys keys/options)
    private bool decisionTime;
    
    //link to the gameObject using the applicantCapsualPrefab (drag the prefab to the Script)
    public GameObject currentApplicantPrefab;

    //link to theCrew (holds lists) (drag the ship here)
    public GameObject theCrew;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
        ////create a new array called newApplicant that can be filled with only Applicant scripts. = Find Objects of the type <Applicant> and put them in the array
        //if (currentApplicant != null)
        //{
        //    Applicant[] newApplicant = FindObjectsOfType<Applicant>();

        //    if (newApplicant != null)
        //    {
        //        for (int i = 0; i < newApplicant.Length; i++)
        //        {
        //            Debug.Log(newApplicant[i].GetName);
        //        }
        //    }
        //}
    }

    // Update is called once per frame
    void Update()
    {

        //If decisionTime = true AND the player presses H run decisionHire(); 
        //If decisionTime = true AND the player presses D run decisionDisgard();
        
    }

    public void newApplicant()
    { 
      //run Possibilitys.csRandomiser() in ApplicantOption script (randomises stats)
      //spawn a new instance of applicant prefab with isCrew bool already false
      //check for isCrew bool false applicant and set as CurrentApplicant 
      //Set CurrentApplicant’s details by running SetStats()
      //show CurrentApplicant's name and hobby to player on the UI
      //tell the buttons they are useable by setting decisionTime bool = true
    }
    /// <summary>
    /// Decision time runs if decisionTime bool = true AND the player presses H 
    /// </summary>
    public void decisionHire()
    {
        //set decisionTime to false
        //change text to read :You have Hired “currentapplicantsName”
        //Move/translate ApplicantCapsule to the RIGHT off screen
        //check if current applicant is a pirate?
        //If is Pirate true :
        //null check list is 1 or more true
        // randomly select a number and change murderTime string to that number’s word from hobby list
        //for loop that goes through the crewHobbys list and DESTROYS all Applicant prefabs that have the hobby  (maybe add && isCrew = true so it 100% wont destroy the Possibilitys.cs?)
        //also destroy currentApplicant 
        //updateCrewCount()
        //change text to read :You have Hired “currentapplicantsName”. They caused a scene in the “murderTime” group and have killed and looted all of them. You now need “(10 - current number of crewMembers)”
        //null check list is 1 or more False
        //destroy currentApplicant 
        //updateCrewCount()
        //change text to read :You have Hired “currentapplicantsName”. They realised there was nothing interesting to do and left your crew. You now need “(10 - current number of crewMembers)” crew.

    }
}
