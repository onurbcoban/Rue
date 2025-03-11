using UnityEngine;
using UnityEngine.UI;

public class ShowCreamTwo : Cream
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.First();
    }

    public void MakeCreamTwo()
    {
        if(showCake.clickCount != 0)
        {
        click++;
        }
        
        if(showFlavorOne.click == 0 && showFlavorTwo.click == 0 && showFlavorThree.click == 0)//süsleme koyduktan sonra krema konulamaz
        {

        if(cakeToShowFirst.gameObject.activeSelf && !cakeToShowSecond.gameObject.activeSelf && !cakeToShowThird.gameObject.activeSelf)
        {
            cotsOne.gameObject.SetActive(false);
            cotsTwo.gameObject.SetActive(false);
            cotsThree.gameObject.SetActive(false);
            cttsOne.gameObject.SetActive(true);
            cttsTwo.gameObject.SetActive(false);
            cttsThree.gameObject.SetActive(false);       
        }
        if(cakeToShowFirst.gameObject.activeSelf && cakeToShowSecond.gameObject.activeSelf && !cakeToShowThird.gameObject.activeSelf)
        {
            cotsOne.gameObject.SetActive(false);
            cotsTwo.gameObject.SetActive(false);
            cotsThree.gameObject.SetActive(false);
            cttsOne.gameObject.SetActive(true);
            cttsTwo.gameObject.SetActive(true);
            cttsThree.gameObject.SetActive(false);
        }
        if(cakeToShowFirst.gameObject.activeSelf && cakeToShowSecond.gameObject.activeSelf && cakeToShowThird.gameObject.activeSelf)
        {
            cotsOne.gameObject.SetActive(false);
            cotsTwo.gameObject.SetActive(false);
            cotsThree.gameObject.SetActive(false);
            cttsOne.gameObject.SetActive(true);
            cttsTwo.gameObject.SetActive(true);
            cttsThree.gameObject.SetActive(true);
        }
        }
    }
}