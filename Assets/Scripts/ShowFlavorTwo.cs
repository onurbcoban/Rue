using UnityEngine;
using UnityEngine.UI;

public class ShowFlavorTwo : Flavor
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.First();
    }

    public void MakeFlavorTwo()
    {
        if(showCreamOne.click != 0 || showCreamTwo.click != 0)//krema koymadan süsleme konulamaz
        {
            click++;
        if(cakeToShowFirst.gameObject.activeSelf && !cakeToShowSecond.gameObject.activeSelf && !cakeToShowThird.gameObject.activeSelf)
        {
            fotsOne.gameObject.SetActive(false);
            fotsTwo.gameObject.SetActive(false);
            fotsThree.gameObject.SetActive(false);
            fttsOne.gameObject.SetActive(true);
            fttsTwo.gameObject.SetActive(false);
            fttsThree.gameObject.SetActive(false);
            ftitsOne.gameObject.SetActive(false);
            ftitsTwo.gameObject.SetActive(false);
            ftitsThree.gameObject.SetActive(false);       
        }
        if(cakeToShowFirst.gameObject.activeSelf && cakeToShowSecond.gameObject.activeSelf && !cakeToShowThird.gameObject.activeSelf)
        {
            fotsOne.gameObject.SetActive(false);
            fotsTwo.gameObject.SetActive(false);
            fotsThree.gameObject.SetActive(false);
            fttsOne.gameObject.SetActive(false);
            fttsTwo.gameObject.SetActive(true);
            fttsThree.gameObject.SetActive(false);
            ftitsOne.gameObject.SetActive(false);
            ftitsTwo.gameObject.SetActive(false);
            ftitsThree.gameObject.SetActive(false);
        }
        if(cakeToShowFirst.gameObject.activeSelf && cakeToShowSecond.gameObject.activeSelf && cakeToShowThird.gameObject.activeSelf)
        {
            fotsOne.gameObject.SetActive(false);
            fotsTwo.gameObject.SetActive(false);
            fotsThree.gameObject.SetActive(false);
            fttsOne.gameObject.SetActive(false);
            fttsTwo.gameObject.SetActive(false);
            fttsThree.gameObject.SetActive(true);
            ftitsOne.gameObject.SetActive(false);
            ftitsTwo.gameObject.SetActive(false);
            ftitsThree.gameObject.SetActive(false);
        }
        }
    }
}

