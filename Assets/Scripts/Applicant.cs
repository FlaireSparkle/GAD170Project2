using UnityEngine;

public class Applicant : MonoBehaviour
{
    private string myName;
    private string myHobby;
    private bool isPirate;
    public bool isCrew = false;
    //Make Possibilitys script Viewable
    public Possibilitys randomizeStats;

    public void StatCreation()
    {
        //double down on not being part of the crew yet
        isCrew = false;
        //roll the dice (set the stats in Possibilitys script)
        randomizeStats.SetApplicantStats();
        //copy the stats over
        myName = ((randomizeStats.nameFirst) + " " + (randomizeStats.nameLast));
        myHobby = (randomizeStats.hobby);
        isPirate = (randomizeStats.isPirate);
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
}
