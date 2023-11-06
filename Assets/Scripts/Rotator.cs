using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _duration = 1f;

    private Vector3 _angleRotation = new(0, 180, 0);

    private void Start()
    {
        transform.DORotate(_angleRotation, _duration).SetLoops(-1).SetEase(Ease.Linear);
    }
}
