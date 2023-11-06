using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class CorrectorText : MonoBehaviour
{
    [SerializeField] Text _text1;
    [SerializeField] Text _text2;
    [SerializeField] Text _text3;

    private string _replacedText = "���������� �����.";
    private string _addedText = "����������� �����.";
    private string _overdoneText = "����������� �����.";

    private float _duration = 3f;

    void Start()
    {
        _text1.DOText(_replacedText, _duration);
        _text2.DOText(_addedText, _duration).SetRelative();
        _text3.DOText(_overdoneText, _duration, true, ScrambleMode.All);
    }
}
