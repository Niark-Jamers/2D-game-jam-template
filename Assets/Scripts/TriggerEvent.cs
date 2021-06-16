using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    public UnityEvent onTriggerEnter;
    public UnityEvent onTriggerExit;
    public UnityEvent onTriggerStay;

    void OnTriggerEnter2D(Collider2D collider2D) => onTriggerEnter?.Invoke();
    void OnTriggerExit2D(Collider2D collider2D) => onTriggerExit?.Invoke();
    void OnTriggerStay2D(Collider2D collider2D) => onTriggerStay?.Invoke();
}
