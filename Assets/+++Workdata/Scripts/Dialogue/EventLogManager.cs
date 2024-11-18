using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EventLogManager : MonoBehaviour
{
    #region VARIABLES

    //test

    #endregion

    public TextMeshProUGUI eventLog_Text;
    public Animator animator;

    public float visibleTime = 2f;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        eventLog_Text = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void SetEventLogText(string textValue)
    {
        eventLog_Text.SetText(textValue);

        StartCoroutine(InitiateEventLog());
    }

    IEnumerator InitiateEventLog()
    {
        animator.Play("FadeIn");
        yield return new WaitForSeconds(visibleTime);
        animator.Play("FadeOut");
    }

}