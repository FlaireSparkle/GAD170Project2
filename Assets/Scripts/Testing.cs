using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    //set variables
    //gameObject using the applicantCapsualPrefab (drag this to the Script)
    public GameObject applicantPrefab;
    public List<Applicant> allApplicants = new List<Applicant> ();
   
    public Applicant currentApplicant;

    // Start is called before the first frame update
    void Start()
    {
        //for loop


        //set applicant as "currentApplicant" and create applicant
        currentApplicant = Instantiate(applicantPrefab).GetComponent<Applicant>();
        //set prefab stats in that instance (which will first randomize stats in possibilitys)
        currentApplicant.StatCreation();

        //set current applicant reference 
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
        
        Debug.Log("has run");
    }
    /// <summary>
    /// public void contains Keys for testing 
    /// </summary>
    public void Update()
    {
        //if (Input.GetKeyDown(KeyCode.P))
        //{
        //   // currentApplicant.gameObject.StatCreation();
        //    Debug.Log("The applicant's name is " + Applicant.GetName);
        //}

    }
}
