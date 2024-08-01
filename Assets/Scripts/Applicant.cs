using UnityEngine;

public class Applicant : MonoBehaviour
{
    private string myName = "unknown";
    private string myHobby = "unknown";
    private bool isPirate = false;
    public bool isCrew = false;
    //Make Possibilitys script Viewable
    public Possibilitys currentPossibilitys;
    

    public void StatCreation()
    {
        //double down on not being part of the crew yet
        isCrew = false;
        //roll the dice (set the stats in Possibilitys script)
        currentPossibilitys.SetApplicantStats();
        //copy the stats over
        myName = ((currentPossibilitys.nameFirst) + " " + (currentPossibilitys.nameLast));
        myHobby = (currentPossibilitys.hobby);
        isPirate = (currentPossibilitys.isPirate);
        
    }

    public string GetName
    {
        get
        { return myName; }
        set{}
    }
    public string GetHobby
    {
        get
        { return myHobby; }
        set { }
    }
    public bool GetIsPirate
    {
        get
        { return isPirate; }
        set { }
    }
}
