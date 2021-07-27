using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DelayedTrigger : MonoBehaviour
{
    public float delayInSeconds = 1;

    public UnityEvent onAfterDelay;

    void OnEnable()
    {
        StartCoroutine(Trigger());
    }

    IEnumerator Trigger()
    {
        yield return new WaitForSeconds(delayInSeconds);
        onAfterDelay?.Invoke();
    }
}
