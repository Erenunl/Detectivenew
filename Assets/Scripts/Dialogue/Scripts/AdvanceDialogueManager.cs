using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AdvanceDialogueManager : MonoBehaviour
{
    private AdvancedDialogueSO currentConversation;
    private int stepNum;
    private bool dialogueActivated;

    private GameObject dialogueCanvas;
    private TMP_Text actor;
    private TMP_Text dialogueText;

    private string currentSpeaker;

    public ActorSO[] actorSO;


    private GameObject[] optionButton;
    private TMP_Text[] optionButtonText;
    private GameObject optionsPanel;

    // Start is called before the first frame update
    void Start()
    {
        optionButton = GameObject.FindGameObjectsWithTag("OptionButton");
        optionsPanel = GameObject.Find("OptionsPanel");
        optionsPanel.SetActive(false);

        optionButtonText = new TMP_Text[optionButton.Length];

        for (int i = 0; i < optionButton.Length; i++)
        {
            optionButtonText[i] = optionButton[i].GetComponentInChildren<TMP_Text>();
        }

        for (int i = 0; i < optionButton.Length; i++)
        {
            optionButton[i].SetActive(false);
        }


        dialogueCanvas = GameObject.Find("DialogueCanvas");
        actor = GameObject.Find("ActorText").GetComponent<TMP_Text>();
        dialogueText = GameObject.Find("DialogueText").GetComponent<TMP_Text>();

        dialogueCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogueActivated && Input.GetKeyDown(KeyCode.E))
        {
            if (stepNum >= currentConversation.actors.Length)
            {
                TurnOffDialogue();
            }
            else
            {
                PlayDialogue();
            }
        }
    }


    private void PlayDialogue()
    {

        if (currentConversation.actors[stepNum] == DialogueActors.Random)
        {
            SetActorInfo(false);
        }
        else
        {
            SetActorInfo(true);
        }

        actor.text = currentSpeaker;

        if (currentConversation.actors[stepNum] == DialogueActors.Branch)
        {
            for (int i = 0; i < currentConversation.optionText.Length; i++)
            {
                if (currentConversation.optionText[i] == null)
                {
                    optionButton[i].SetActive(false);
                }
                else
                {
                    optionButtonText[i].text = currentConversation.optionText[i];
                    optionButton[i].SetActive(true);
                }

                //Set the first button to be auto-selected
                //optionButton[0].GetComponent<Button>().Select();

            }
        }


        if (stepNum < currentConversation.dialogue.Length)
        {
            dialogueText.text = currentConversation.dialogue[stepNum];
        }
        else
        {
            optionsPanel.SetActive(true);
        }

        dialogueText.text = currentConversation.dialogue[stepNum];
        dialogueCanvas.SetActive(true);
        stepNum += 1;
    }


    private void SetActorInfo(bool recurringCharacter)
    {
        if (recurringCharacter)
        {
            for (int i = 0; i < actorSO.Length; i++)
            {
                if (actorSO[i].name == currentConversation.actors[stepNum].ToString())
                {
                    currentSpeaker = actorSO[i].actorName;
                }
            }
        }
        else
        {
            currentSpeaker = currentConversation.randomActorName;
        }
    }


    public void Option(int optionNum)
    {
        foreach (GameObject button in optionButton)
            button.SetActive(false);

        if (optionNum == 0)
            currentConversation = currentConversation.option0;
        if (optionNum == 1)
            currentConversation = currentConversation.option1;
        if (optionNum == 2)
            currentConversation = currentConversation.option2;
        if (optionNum == 3)
            currentConversation = currentConversation.option3;

        stepNum = 0;
    }

    public void InitiateDialogue(NPCDialogue npcDialogue)
    {
        currentConversation = npcDialogue.conversation[0];
        Debug.Log("Started conversation: " + currentConversation);
        dialogueActivated = true;
    }

    public void TurnOffDialogue()
    {
        stepNum = 0;
        Debug.Log("Ended conversation. Reset the step to " + stepNum);
        dialogueActivated = false;
        optionsPanel.SetActive(false);
        dialogueCanvas.SetActive(false);
    }

}
public enum DialogueActors
{
    Dedective,
    Drunk,
    Jonathan,
    Alex,
    Jessica,
    Barman,
    BodyGuard,
    Homeless,
    Anthony,

    Random,
    Branch,
};
