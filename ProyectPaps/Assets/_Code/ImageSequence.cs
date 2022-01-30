using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageSequence : MonoBehaviour
{
    public SequenceManager sequenceManager;
    public void Update()
    {
        if (this.gameObject.activeInHierarchy && Input.GetMouseButtonDown(1))
        {
            sequenceManager.continueSequence();
        }
    }
}
