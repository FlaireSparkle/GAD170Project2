using UnityEngine;

public class Testing : MonoBehaviour
{
    //set variables
    //gameObject using the applicantCapsualPrefab (drag this to the Script)
    public GameObject currentApplicant;


    // Start is called before the first frame update
    void Start()
    {
       //set current applicant reference 

    }

    /// <summary>
    /// public void contains Keys for testing 
    /// </summary>
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
           // currentApplicant.gameObject.StatCreation();
            Debug.Log("The applicant's name is " + currentApplicant);
        }

    }
}
