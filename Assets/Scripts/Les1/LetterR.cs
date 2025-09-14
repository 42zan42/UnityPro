using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LetterR : MonoBehaviour, ICA
{
    private MeshRenderer _meshRenderer;
    private Material _material;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _material = _meshRenderer.material;
    }
    public void OnClick()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_material.DOColor(Color.cyan, 0.42f));
        sequence.AppendInterval(1.42f);
        sequence.Append(_material.DOColor(Color.white, 0.742f));

        sequence.Play();
    }
}
