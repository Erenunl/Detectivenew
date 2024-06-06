using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static AdvanceDialogueManager;

[CreateAssetMenu]
public class AdvancedDialogueSO : ScriptableObject
{
    public DialogueActors[] actors;

    [Tooltip("Only needed if Random is selected as the actor name")]
    [Header("Random Actor Info")]
    public string randomActorName;

    [Header("Dialogue")]
    [TextArea]
    public string[] dialogue;

    [Tooltip("The words that will appear on option buttons")]
    public string[] optionText;

    public AdvancedDialogueSO option0;
    public AdvancedDialogueSO option1;
    public AdvancedDialogueSO option2;
    public AdvancedDialogueSO option3;
}
