using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TextIterator : MonoBehaviour
{
    private Coroutine corIterateText;
    private TextMeshProUGUI textMesh;
    private SequenceManager sequenceManager;
    private bool finished = false;

    [Header("Iteration speed")]
    [SerializeField] private float textSpeed = 0.01f;

    public void Awake()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    public void Start()
    {
        try
        {
        sequenceManager = FindObjectOfType<SequenceManager>();
        }
        catch (Exception e)
        {
            print("The sequence manager can't be found");
        }
    }

    public void OnEnable()
    {
        finished = false;
        textMesh.maxVisibleCharacters = 0;
        Show();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(2) && finished == false)
        {
            skip();
        } else if (Input.GetMouseButtonDown(1) && finished == true && this.gameObject.tag != "Decision")
        {
            sequenceManager.continueSequence();
        }
        checkForContinue();
    }

    private void skip()
    {
        if (corIterateText != null)
        {
            StopCoroutine(corIterateText);
        }
        textMesh.maxVisibleCharacters = textMesh.text.Length;
        finished = true;
    }

    public void Show()
    {
        if (corIterateText != null)
        {
            StopCoroutine(corIterateText);
        }
        finished = false;
        corIterateText = StartCoroutine(CorIterateText(textMesh));
    }

    IEnumerator CorIterateText(TextMeshProUGUI myTextMesh)
    {
        for (int i = 0; i < myTextMesh.text.Length; i++)
        {
            myTextMesh.maxVisibleCharacters++;
            yield return new WaitForSeconds(textSpeed);
        }
        finished = true;
    }

    private void checkForContinue()
    {
        if (this.gameObject.tag == "Decision")
        {
            sequenceManager.continueButton.SetActive(false);
        } else if(finished == true)
        {
            sequenceManager.continueButton.SetActive(true);
        } else if(finished == false)
        {
            sequenceManager.continueButton.SetActive(false);
        }
    }
}
