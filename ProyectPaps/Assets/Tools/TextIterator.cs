using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextIterator : MonoBehaviour
{
    private Coroutine corIterateText;
    private TextMeshProUGUI textMesh;
    private bool finished = false;

    [Header("Iteration speed")]
    [SerializeField] private float textSpeed = 0.01f;

    public void Awake()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
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
        }
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
}
