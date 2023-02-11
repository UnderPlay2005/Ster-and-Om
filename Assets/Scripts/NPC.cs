using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
public class NPC : MonoBehaviour
{
    // NPCConversation Variable (assigned in Inspector)
    public NPCConversation Conversation;
    void OnTriggerEnter2D()
    {
        ConversationManager.Instance.StartConversation(Conversation);
    }
}
