using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollectGems : MonoBehaviour
{
    [SerializeField] private UnityEvent _collected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Thief>(out Thief thief)) 
        {
            _collected?.Invoke();
        }
    }
}
