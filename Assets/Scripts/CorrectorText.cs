using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class CorrectorText : MonoBehaviour
{
    [SerializeField] private Text _textToBeReplaced;
    [SerializeField] private Text _textToAddTextTo;
    [SerializeField] private Text _textToBulkhead;

    private string _replacedText = "Замененный текст.";
    private string _addedText = "Добавленный текст.";
    private string _overdoneText = "Перебранный текст.";

    private float _duration = 3f;

    private void Start()
    {
        _textToBeReplaced.DOText(_replacedText, _duration);
        _textToAddTextTo.DOText(_addedText, _duration).SetRelative();
        _textToBulkhead.DOText(_overdoneText, _duration, true, ScrambleMode.All);
    }
}
