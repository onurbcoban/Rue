using UnityEngine;
using UnityEngine.UI;

public class ShowFlavorTwo : MonoBehaviour
{
    public ShowCake showCake;
    public ShowCreamOne showCreamOne;
    public ShowCreamTwo showCreamTwo;
    public int clickTwo = 0;
    public Image fotsOne, fotsTwo, fotsThree;
    public Image fttsOne, fttsTwo, fttsThree;
    public Image ftitsOne, ftitsTwo, ftitsThree;
    public Image cakeToShowFirst, cakeToShowSecond, cakeToShowThird;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
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

    public void MakeFlavorTwo()
    {
        if(showCreamOne.clickOne != 0 || showCreamTwo.clickTwo != 0)//krema koymadan süsleme konulamaz
        {
            clickTwo++;
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

