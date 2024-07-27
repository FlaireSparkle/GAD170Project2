using UnityEngine;

public class Applicant : MonoBehaviour
{
    public string myName;
    public string myHobby;
    public bool killSomeCrew;
    public ApplicantOptions currentRandomStats;
    public void Start()
    {
        currentRandomStats.SetApplicantStats();
        myName = ((currentRandomStats.nameFirst) + " " + (currentRandomStats.nameLast));
        myHobby = (currentRandomStats.hobby);
        killSomeCrew = (currentRandomStats.isPirate);
    }


}
