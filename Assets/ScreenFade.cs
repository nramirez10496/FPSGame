using UnityEngine;
using UnityEngine.UI;

public class ScreenFade : MonoBehaviour
{
    [SerializeField] Color targetColor=Color.clear;
    [SerializeField] Image fadeImage;
    [SerializeField] float fadeSpeed=1;
    
    // Update is called once per frame
    void Update()
    {
        var currentColor = fadeImage.color;

        currentColor = Color.Lerp(currentColor, targetColor, fadeSpeed * Time.deltaTime);//fade current color to target color

        fadeImage.color = currentColor;
    }

    public void TargetColorRed()
    {
        targetColor = Color.red;//set the screen color to red
    }

    public void TargetColorClear()
    {
        targetColor.a = 0;//set the screen color to clear
    }

    public void FadeScreen()
    {
        TargetColorRed();//red screen
        Invoke(nameof(TargetColorClear), .6f);//call clear screen after .6 seconds
    }
}
