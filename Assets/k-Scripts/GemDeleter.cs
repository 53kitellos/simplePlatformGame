using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemDeleter : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private Color _targetColor;

    public void Change()
    {
        _renderer.color = _targetColor;
    }
}
