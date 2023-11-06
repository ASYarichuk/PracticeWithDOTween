using UnityEngine;
using DG.Tweening;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _duration = 3f;

    private Vector3 _scale = new(2, 2, 2);

    private void Start()
    {
        transform.DOScale(_scale, _duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
