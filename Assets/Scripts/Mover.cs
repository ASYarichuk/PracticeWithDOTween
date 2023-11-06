using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _duration = 100f;
    [SerializeField] private float _distance = 100f;

    private void Start()
    {
        transform.DOMoveZ(_distance, _duration).SetLoops(-1);
    }
}

