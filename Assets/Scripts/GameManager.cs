using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public Player player;
    public DialogueManager dialogueManager; 
    public TextMeshProUGUI gameOverText; 
    public TextMeshProUGUI endingText; 

    private int currentDialogueIndex = 0;
    private int playerHealth;

    public DialogueOption[] dialogueOptions; 

    private bool isGameOver = false;

    private void Start()
    {
        playerHealth = player.health;
        StartDialogue();
    }

    private void StartDialogue()
    {
        if (currentDialogueIndex < dialogueOptions.Length && !isGameOver)
        {
            dialogueManager.StartDialogue(dialogueOptions[currentDialogueIndex]);
        }
        else
        {
            if (playerHealth <= 0)
            {
                gameOverText.gameObject.SetActive(true);
            }
            else
            {
                endingText.gameObject.SetActive(true);
            }
        }
    }

    public void HandleDialogueEnd()
    {
        currentDialogueIndex++;
        playerHealth = player.health;

        if (playerHealth <= 0 || currentDialogueIndex >= dialogueOptions.Length)
        {
            isGameOver = true;
        }

        StartDialogue();
    }
}
