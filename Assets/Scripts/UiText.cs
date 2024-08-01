using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //adds textmesh pro engine

public class UiText : MonoBehaviour
{
    public TextMeshProUGUI textBubble;
    public TextMeshProUGUI nameBubble;
    public TextMeshProUGUI hobbyBubble;
    public TextMeshProUGUI playerPromptBubble;
    public TheSystemCube TheSystemCube;

    public TextMeshProUGUI scoreText;
    public int timer = 0;

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
        #region Testing Key
        if (Input.GetKeyDown(KeyCode.U))
        {
            nameBubble.text = "Name:  ";

        }
        #endregion
        timer++;
        scoreText.text = "the time is " + timer;
    }
    public void SpaceToContinue()
    {
        playerPromptBubble.text = "press Space to continue";
        //Debug.Log("spacebar prompted");
    }

    public void ActivateHireingModeUI()
    {
        //string applicantsName = Applicant.GetName;
        //string applicantsHobby = Applicant.GetHobby;
        //"will you hire" becomes visable
        //nametmp = "Name: " + currentApplicant's Name & becomes visable
        nameBubble.text = ("Name:  " + (TheSystemCube.currentApplicant.GetName));
        //hobbytmp = "Hobby: " + currentApplicant's Hobby & becomes visable
        hobbyBubble.text = ("Hobby:  " + TheSystemCube.currentApplicant.GetHobby);
        //D to Discard and H to Hire become visable
        playerPromptBubble.text = ("D to Discard  or  H to Hire");
        
    }
    public void DeactivateTextUI()
    {
        //"will you hire" becomes invisable
        //nametmp becomes invisable
        nameBubble.text = " ";
        hobbyBubble.text = " ";
        playerPromptBubble.text = " ";
        textBubble.text = " ";
        //hobbytmp becomes invisable
        //D to Discard and H to Hire becomes invisable
    }
    
    //turns on the text bubble with the attached text set.
    public void ActivateTextBubbleUI(int bubbleNumber)
    { 
        //sets text //turns on visibility of text
       if (bubbleNumber == 1)
        {
            nameBubble.text = ("You are almost ready to set off on your next adventure, the only thing stopping you is your lack of crew. You have narrowed down the applicants to those who meet the job requirements.");
            Debug.Log("You are the captian of a ship");
            Debug.Log("You are almost ready to set off on your next adventure, the only thing stopping you is your lack of crew. You have narrowed down the applicants to those who meet the job requirements.");
        }
        

    }
}
