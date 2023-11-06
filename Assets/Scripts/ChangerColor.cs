using UnityEngine;
using DG.Tweening;

public class ChangerColor : MonoBehaviour
{
    [SerializeField] private float _duration = 3f;

    private Color _color = Color.red;

    private void Start()
    {
        Renderer renderer = GetComponent<Renderer>();

        renderer.material.DOColor(_color, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}


