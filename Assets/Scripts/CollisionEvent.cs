using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEvent : MonoBehaviour
{
    public UnityEvent onCollisionEnter;
    public UnityEvent onCollisionExit;
    public UnityEvent onCollisionStay;

    void OnCollisionEnter2D(Collision2D collider2D) => onCollisionEnter?.Invoke();
    void OnCollisionExit2D(Collision2D collider2D) => onCollisionExit?.Invoke();
    void OnCollisionStay2D(Collision2D collider2D) => onCollisionStay?.Invoke();
}
