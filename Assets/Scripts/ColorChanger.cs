using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Renderer))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private float _duration = 2f;

    private Color _color = Color.red;

    private void Start()
    {
        Renderer renderer = GetComponent<Renderer>();

        renderer.material.DOColor(_color, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}


