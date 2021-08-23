using HomaGames.Internal.BaseTemplate;
using UnityEngine;
using UnityEngine.UI;

public class DistanceCounterSlider : MonoBehaviour
{
    Slider _slider;
    [SerializeField]
    string propId = "Distance";

    void Start()
    {
        _slider = GetComponent<Slider>();
        GameManagerBase.Instance.Context.OnContextChanged += OnContextChanged;
    }

    private void OnContextChanged(GameContext obj)
    {
        _slider.value = (float)obj.GetValue(propId);
    }
}
