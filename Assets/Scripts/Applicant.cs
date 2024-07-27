using UnityEngine;

public class Applicant : MonoBehaviour
{
    public bool isPirate = false;
    public void Start()
    {
        isPirate = false;
        int pirateNumber = (Random.Range(1, 4));
        Debug.Log("Pirate Number is " + pirateNumber);
        //randomly set the isPirate bool between true and false
        if(pirateNumber==3)
        {
            isPirate = true;
        }
        else
        {
            isPirate=false;
        }
            
    }
   
    /////this region makes some variables readable by other scripts///
    //#region Other Scripts Call Information
    ////allow different parts to be viewed by other scripts
    //public string getFirstName()
    //{
    //    return firstName;
    //}
    //public char getLastName()
    //{
    //    return lastName;
    //}
    //public string getHobby()
    //{
    //    return hobby;
    //}

    //public void getApplicantStats()
    //{
    //    getFirstName();
    //    getLastName();
    //    getHobby();

    //}

    //#endregion


}
