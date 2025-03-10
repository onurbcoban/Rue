using UnityEngine;
using UnityEngine.UI;

public class ShowCreamOne : MonoBehaviour
{
    public ShowCake showCake;
    public ShowFlavorOne showFlavorOne;
    public ShowFlavorTwo showFlavorTwo;
    public ShowFlavorThree showFlavorThree;
    public int clickOne = 0;
    public Image cotsOne, cotsTwo, cotsThree;
    public Image cttsOne, cttsTwo, cttsThree;
    public Image cakeToShowFirst, cakeToShowSecond, cakeToShowThird;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cotsOne.gameObject.SetActive(false);
        cotsTwo.gameObject.SetActive(false);
        cotsThree.gameObject.SetActive(false);
        cttsOne.gameObject.SetActive(false);
        cttsTwo.gameObject.SetActive(false);
        cttsThree.gameObject.SetActive(false);
    }

    public void MakeCreamOne()
    {
        if(showCake.clickCount != 0)
        {
        clickOne++;
        }

        if(showFlavorOne.clickOne == 0 && showFlavorTwo.clickTwo == 0 && showFlavorThree.clickThree == 0)
        {
        if(cakeToShowFirst.gameObject.activeSelf && !cakeToShowSecond.gameObject.activeSelf && !cakeToShowThird.gameObject.activeSelf)
        {
            cotsOne.gameObject.SetActive(true);
            cotsTwo.gameObject.SetActive(false);
            cotsThree.gameObject.SetActive(false);
            cttsOne.gameObject.SetActive(false);
            cttsTwo.gameObject.SetActive(false);
            cttsThree.gameObject.SetActive(false);       
        }
        if(cakeToShowFirst.gameObject.activeSelf && cakeToShowSecond.gameObject.activeSelf && !cakeToShowThird.gameObject.activeSelf)
        {
            cotsOne.gameObject.SetActive(true);
            cotsTwo.gameObject.SetActive(true);
            cotsThree.gameObject.SetActive(false);
            cttsOne.gameObject.SetActive(false);
            cttsTwo.gameObject.SetActive(false);
            cttsThree.gameObject.SetActive(false);
        }
        if(cakeToShowFirst.gameObject.activeSelf && cakeToShowSecond.gameObject.activeSelf && cakeToShowThird.gameObject.activeSelf)
        {
            cotsOne.gameObject.SetActive(true);
            cotsTwo.gameObject.SetActive(true);
            cotsThree.gameObject.SetActive(true);
            cttsOne.gameObject.SetActive(false);
            cttsTwo.gameObject.SetActive(false);
            cttsThree.gameObject.SetActive(false);
        }
        }
    }
}
