using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SequenceManager : MonoBehaviour
{
    [Header("Canvas sequence")]
    [SerializeField] private GameObject[] sequence;

    [Header("Buttons")]
    [SerializeField] private GameObject startButton;
    public GameObject continueButton;

    [Header("Name of scene to load")]
    [SerializeField] private string sceneToLoad;

    [Header("End Game scene")]
    [SerializeField] private string finalScene;

    private int sequenceIndex = 0;

    void Start()
    {
        foreach(GameObject canvas in sequence)
        {
            canvas.SetActive(false);
        }
        sequenceIndex = 0;
        continueButton.SetActive(false);
        StartCoroutine(waitForLoad());
    }

    public void startSequence()
    {
        sequence[0].SetActive(true);
        sequenceIndex = 0;
        startButton.SetActive(false);
        checkForDecision();
    }

    public void continueSequence()
    {
        if (sequenceIndex != sequence.Length - 1)
        {
        sequence[sequenceIndex].gameObject.SetActive(false);
        sequenceIndex++;
        sequence[sequenceIndex].gameObject.SetActive(true);
        checkForDecision();
        } else
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    public void endGame()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    private void checkForDecision()
    {
        if (sequence[sequenceIndex].gameObject.tag == "Decision")
        {
            continueButton.SetActive(false);
        } else
        {
            continueButton.SetActive(true);
        }
    }

    private IEnumerator waitForLoad()
    {
        yield return new WaitForFixedUpdate();
        startSequence();
    }
}
