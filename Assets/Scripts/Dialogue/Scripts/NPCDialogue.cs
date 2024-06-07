using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDialogue : MonoBehaviour
{
    public AdvancedDialogueSO[] conversation;

    private Transform player;
    private SpriteRenderer speechBubbleRenderer;

    private AdvanceDialogueManager advanceDialogueManager;

    private bool dialogueInitiated;

    // Start is called before the first frame update
    void Start()
    {
        advanceDialogueManager = GameObject.Find("DialogueManager").GetComponent<AdvanceDialogueManager>();
        speechBubbleRenderer = GetComponent<SpriteRenderer>();
        speechBubbleRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !dialogueInitiated) 
        {
            speechBubbleRenderer.enabled = true;

            player = collision.gameObject.GetComponent<Transform>();

            if (player.position.x > transform.position.x && transform.parent.localScale.x < 0)
            {
                Flip();
            }
            else if (player.position.x < transform.position.x && transform.parent.localScale.x > 0)
            {
                Flip();
            }

            advanceDialogueManager.InitiateDialogue(this);
            dialogueInitiated = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            speechBubbleRenderer.enabled= false;

            advanceDialogueManager.TurnOffDialogue();
            dialogueInitiated = false;
        }
    }

    private void Flip()
    {
        Vector3 currentScale = transform.parent.localScale;
        currentScale.x *= -1;
        transform.parent.localScale = currentScale;
    }
}
