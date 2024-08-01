using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// there should only be one instance of this script. 
/// Applicant Possibilitys is the script that holds all the possible names and information 
/// this information will be randomized (triggered by the applicant) that will be copied into the applicant script when the crew applicant prefab comes into being.
/// </summary>
public class Possibilitys : MonoBehaviour
{
  //bring into existence the variables this script will need
    #region Variables
  //to be used by Applicant Script (prefab)
    public bool isPirate = false;
    public string nameFirst;
    public char nameLast;
    public string hobby;
  
  //only used in this script but MUST be kept Public due to issue of when private the lists are going blank randomly.
    //crewHobby array
    public string[] crewHobby = new string[] { };
    //pirateHobby array
    public string[] pirateHobby = new string[] { };
    //firstName array 
    public string[] firstNames = new string[] { };
    //lastNames array 
    public char[] lastNames = new char[] { };
    #endregion

    /////set the if the applicant is a pirate, what their first name is, what their last initial is and (dependant on if they are a pirate) what their hobby is///
    public void start()
    {
        ////set array text //firstnamearray()//lastnamearray()//piratehobbyarray()//crewhobbyarray()
        //firstNames = new string[] { "apple", "bottom", "Jeans" };

    }
    public void SetApplicantStats()
    {
        #region Are they secretly a Pirate?
        //randomly set the isPirate bool between true and false
        isPirate = false;
        int pirateNumber = (Random.Range(1, 4));
        //Debug.Log("Pirate Number is " + pirateNumber + ".   if = 3 then yes Pirate");

        if (pirateNumber == 3)
        {
            isPirate = true;
        }
        else
        {
            isPirate = false;
        }
        #endregion

        #region Set their First Name
        //randomly select a name from the first names array and set the first name to it
        nameFirst = (firstNames[Random.Range(0, (firstNames.Length - 1))]);
        //Debug.Log("Applicants first name is " + nameFirst);
        #endregion
        #region Set their Last initial
        //randomly select a name from the last names array and set the last name to it
        nameLast = (lastNames[Random.Range(0, (lastNames.Length - 1))]);
        //Debug.Log("Applicants last name initial is " + nameLast);
        #endregion

        #region Randomly Set their Hobby
        //if the applicant is NOT a pirate (isPirate bool == false) choose a hobby from the crew Hobby array and set “hobby” to it
        if (isPirate == false)
        {
            hobby = (crewHobby[Random.Range(0, (crewHobby.Length - 1))]);
        }
        //if the applicant is a pirate (isPirate bool == true) choose a hobby from the pirate Hobby array and set “hobby” to it
        else if (isPirate == true)
        {
            hobby = (pirateHobby[Random.Range(0, (pirateHobby.Length - 1))]);
        }
        //Debug.Log("Applicants hobby is " + hobby);
        #endregion
    }
    #region hard coded arrays
    private void firstNameArray()
    {
        firstNames = new string[] {"apple", "bottom","Jeans"};
        lastNames = new char[] { 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', };
    }
    //lastNameArray()

    //pirateHobbyArray()

    //crewHobbyArray()
    #endregion
}
