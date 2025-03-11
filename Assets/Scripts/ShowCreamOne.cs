using UnityEngine;
using UnityEngine.UI;

public class ShowCreamOne : Cream
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.First();
    }

    public void MakeCreamOne()
    {
        if(showCake.clickCount != 0)
        {
        click++;
        }

        if(showFlavorOne.click == 0 && showFlavorTwo.click == 0 && showFlavorThree.click == 0)
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
