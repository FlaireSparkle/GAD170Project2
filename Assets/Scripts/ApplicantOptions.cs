using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicantOptions : MonoBehaviour
{
    //bring into existence the variables this script will need
    #region Variables needed
    public bool isPirate = false;
    public string nameFirst;
    public char nameLast;
    public string hobby;
    //crewHobby array
    public string[] crewHobby = new string[] { };
    //pirateHobby array
    public string[] pirateHobby = new string[] { };
    //firstName array
    public string[] firstNames = new string[] { };
    //lastNames array
    public char[] lastNames = new char[] { };
    #endregion

    //***note*** they are private because it is required in the outline




    /////set the if the applicant is a pirate, what their first name is, what their last initial is and (dependant on if they are a pirate) what their hobby is///
    private void SetApplicantStats()
    {
         #region Are they secretly a Pirate?
        ////randomly set the isPirate bool between true and false
        isPirate = false;
        int pirateNumber = (Random.Range(1, 4));
        //Debug.Log("Pirate Number is " + pirateNumber);
       
        if (pirateNumber == 3)
        {
            isPirate = true;
        }
        else
        {
            isPirate = false;
        }
        #endregion

        #region What is their First Name?
        ////randomly select a name from the first names array and set the first name to it

        #endregion
        //randomly select a name from the first names array and set the last name to it
        //if the applicant is a pirate (isPirate bool == true) choose a hobby from the pirate Hobby array and set “hobby” to it
        //if the applicant is NOT a pirate (isPirate bool == false) choose a hobby from the crew Hobby array and set “hobby” to it

    }


}
