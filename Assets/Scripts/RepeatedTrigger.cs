using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RepeatedTrigger : MonoBehaviour
{
    public float delayBetweenTwoTriggers = 1;

    public UnityEvent onAfterDelay;

    void OnEnable()
    {
        StopCoroutine("Trigger");
        StartCoroutine("Trigger");
    }

    IEnumerator Trigger()
    {
        onAfterDelay?.Invoke();

        while (true)
        {
            yield return new WaitForSeconds(delayBetweenTwoTriggers);
            onAfterDelay?.Invoke();
        }
    }
}
