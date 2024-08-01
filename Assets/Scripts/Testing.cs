using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
# region set variables
    //gameObject using the applicantCapsualPrefab (drag this to the Script)
    public GameObject applicantPrefab;
    public Applicant currentApplicant;
    public List<Applicant> allApplicants = new List<Applicant> ();
 #endregion

    // Start is called before the first frame update
    void Start()
    {
        NewApplicant();

        //create a new array called newApplicant that can be filled with only Applicant scripts. = Find Objects of the type <Applicant> and put them in the array
        if (currentApplicant != null)
        {
            Applicant[] newApplicant = FindObjectsOfType<Applicant>();

            if (newApplicant != null)
            {
                for (int i = 0; i < newApplicant.Length; i++)
                {
                    Debug.Log(newApplicant[i].GetName);
                }
            }
        }
        
        Debug.Log("testing's start has run");
    }
    /// <summary>
    /// public void contains Keys for testing 
    /// </summary>
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            NewApplicant();
            Debug.Log("The applicant's name is " + currentApplicant.GetName);
            Debug.Log("Their favourite hobby is " + currentApplicant.GetHobby);
        }

    }

    /// runs the setup of a new Applicant///
       public void NewApplicant()
    {
        //set applicant as "currentApplicant" while createing a new applicant (from the prefab)
            currentApplicant = Instantiate(applicantPrefab).GetComponent<Applicant>();
        //set prefab stats in that instance (which will first randomize stats in possibilitys)
            currentApplicant.StatCreation();
        //show CurrentApplicant's name and hobby to player on the UI

        //tell the buttons they are useable by setting decision time bool = true

        }
}
