using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public static CanvasManager Instance;
    
    [SerializeField] private TextMeshProUGUI counterText;

    [SerializeField] private RectTransform timerRectTransform;
    private Image timerImage;

    public Color targetColor;
    public int barFillingTime = 3;

    public bool CanSpecialShoot => timerRectTransform.sizeDelta.x >= this.timerBarWidth;

    private float timerBarWidth;
    private int counter;
    
    private void Awake()
    {
        Instance = this;
        Assert.IsNotNull(counterText);
        Assert.IsNotNull(timerRectTransform);
        
        this.counter = 0;
        this.timerImage = this.timerRectTransform.GetComponent<Image>();
        this.timerBarWidth = timerRectTransform.sizeDelta.x;
    }

    public void IncreaseCounter()
    {
        // To complete
    }

    public void ResetTimer()
    {
        // To complete
    }
}
