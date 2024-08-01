using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //adds textmesh pro engine

public class UiText : MonoBehaviour
{
    public TextMeshProUGUI textBubble;
    public TextMeshProUGUI nameBubble;
    public TextMeshProUGUI hobbyBubble;
     
    //public TextMeshProUGUI buttonDisgard;
    //public TextMeshProUGUI buttonHire;
    //public TextMeshProUGUI buttonContinue;

    // Start is called before the first frame update
    void Start()
    {
        //set all button Text
       
    }
    
    //public Void SetButtonsForHireing() // or should this just be in start?? 
    //{
    ////set button's text.
        //buttonAText = "disgard/trash";
        //buttonBText = "Hire";
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ActivateHireingModeUI(string applicantsName, string applicantsHobby)
    {
        //"will you hire" becomes visable
        //nametmp = "Name: " + currentApplicant's Name & becomes visable
        nameBubble.text = "Name:  " + applicantsName;
        //hobbytmp = "Hobby: " + currentApplicant's Hobby & becomes visable
        //D to Discard and H to Hire become visable
    }
    public void DeactivateHireingModeUI(string applicantsName, string applicantsHobby)
    {
        //"will you hire" becomes visable
        //nametmp = "Name: " + currentApplicant's Name & becomes visable
        
        //hobbytmp = "Hobby: " + currentApplicant's Hobby & becomes visable
        //D to Discard and H to Hire become visable
    }
    
    //turns on the text bubble with the attached text set.
    public void ActivateTextBubbleUI(int bubbleNumber)
    { 
        //sets text
        //turns on visibility of text
    
    }
}
