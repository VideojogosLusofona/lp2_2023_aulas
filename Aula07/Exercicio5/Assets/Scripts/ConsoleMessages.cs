﻿using UnityEngine;

public class ConsoleMessages : MonoBehaviour
{
    // Reference to the event master
    private EventMaster em;

    // Awake is called one time at the beginning
    private void Awake()
    {
        // Get reference to the event master
        em = GetComponent<EventMaster>();
    }

    // Use this to add event listeners
    private void OnEnable()
    {
        em.KeyPress += ShowConsoleMessage;
    }

    // Use this to remove event listeners
    private void OnDisable()
    {
        em.KeyPress -= ShowConsoleMessage;
    }

    // Show in the console which key was pressed
    private void ShowConsoleMessage(char key)
    {
        Debug.Log($"{key} was pressed");
    }
}