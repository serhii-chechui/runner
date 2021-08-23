using HomaGames.Internal.BaseTemplate;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DistanceCounterTMP : MonoBehaviour
{
    TextMeshProUGUI text;
    [SerializeField]
    string format = "{0:0}";
    [SerializeField]
    string propId = "Distance";

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        GameManagerBase.Instance.Context.OnContextChanged += OnContextChanged;
    }

    private void OnContextChanged(GameContext obj)
    {
        text.text = string.Format(format, obj.GetValue(propId));
    }
}
