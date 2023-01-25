using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Patrol : MonoBehaviour
{
    [SerializeField] private Vector3 _finalPoint;

    private void Start()
    {
        transform.DOMove(_finalPoint, 3).SetLoops(-1,LoopType.Yoyo);
    }
}
