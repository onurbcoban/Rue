using UnityEngine;
using UnityEngine.UI;

public class Cream : MonoBehaviour
{

    public ShowCake showCake;
    public ShowFlavorOne showFlavorOne;
    public ShowFlavorTwo showFlavorTwo;
    public ShowFlavorThree showFlavorThree;
    public int click = 0;
    public Image cotsOne, cotsTwo, cotsThree;
    public Image cttsOne, cttsTwo, cttsThree;
    public Image cakeToShowFirst, cakeToShowSecond, cakeToShowThird;
    public void First()
    {
        cotsOne.gameObject.SetActive(false);
        cotsTwo.gameObject.SetActive(false);
        cotsThree.gameObject.SetActive(false);
        cttsOne.gameObject.SetActive(false);
        cttsTwo.gameObject.SetActive(false);
        cttsThree.gameObject.SetActive(false);
    }
}
