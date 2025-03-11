using UnityEngine;
using UnityEngine.UI;

public class Flavor : MonoBehaviour
{
    public ShowCake showCake;
    public ShowCreamOne showCreamOne;
    public ShowCreamTwo showCreamTwo;
    public int click = 0;
    public Image fotsOne, fotsTwo, fotsThree;
    public Image fttsOne, fttsTwo, fttsThree;
    public Image ftitsOne, ftitsTwo, ftitsThree;
    public Image cakeToShowFirst, cakeToShowSecond, cakeToShowThird;
        public void First()
    {
        fotsOne.gameObject.SetActive(false);
        fotsTwo.gameObject.SetActive(false);
        fotsThree.gameObject.SetActive(false);
        fttsOne.gameObject.SetActive(false);
        fttsTwo.gameObject.SetActive(false);
        fttsThree.gameObject.SetActive(false);
        ftitsOne.gameObject.SetActive(false);
        ftitsTwo.gameObject.SetActive(false);
        ftitsThree.gameObject.SetActive(false);
    }
    
}
