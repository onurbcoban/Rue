using UnityEngine;
using UnityEngine.UI;

public class ShowFlavorThree : MonoBehaviour
{
    public ShowCake showCake;
    public ShowCreamOne showCreamOne;
    public ShowCreamTwo showCreamTwo;
    public int clickThree = 0;
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

    public void MakeFlavorThree()
    {
        if(showCreamOne.clickOne != 0 || showCreamTwo.clickTwo != 0)//krema koymadan süsleme konulamaz
        {
            clickThree++;
        if(cakeToShowFirst.gameObject.activeSelf && !cakeToShowSecond.gameObject.activeSelf && !cakeToShowThird.gameObject.activeSelf)
        {
            fotsOne.gameObject.SetActive(false);
            fotsTwo.gameObject.SetActive(false);
            fotsThree.gameObject.SetActive(false);
            fttsOne.gameObject.SetActive(false);
            fttsTwo.gameObject.SetActive(false);
            fttsThree.gameObject.SetActive(false);
            ftitsOne.gameObject.SetActive(true);
            ftitsTwo.gameObject.SetActive(false);
            ftitsThree.gameObject.SetActive(false);       
        }
        if(cakeToShowFirst.gameObject.activeSelf && cakeToShowSecond.gameObject.activeSelf && !cakeToShowThird.gameObject.activeSelf)
        {
            fotsOne.gameObject.SetActive(false);
            fotsTwo.gameObject.SetActive(false);
            fotsThree.gameObject.SetActive(false);
            fttsOne.gameObject.SetActive(false);
            fttsTwo.gameObject.SetActive(false);
            fttsThree.gameObject.SetActive(false);
            ftitsOne.gameObject.SetActive(false);
            ftitsTwo.gameObject.SetActive(true);
            ftitsThree.gameObject.SetActive(false);
        }
        if(cakeToShowFirst.gameObject.activeSelf && cakeToShowSecond.gameObject.activeSelf && cakeToShowThird.gameObject.activeSelf)
        {
            fotsOne.gameObject.SetActive(false);
            fotsTwo.gameObject.SetActive(false);
            fotsThree.gameObject.SetActive(false);
            fttsOne.gameObject.SetActive(false);
            fttsTwo.gameObject.SetActive(false);
            fttsThree.gameObject.SetActive(false);
            ftitsOne.gameObject.SetActive(false);
            ftitsTwo.gameObject.SetActive(false);
            ftitsThree.gameObject.SetActive(true);
        }
        }
    }
}
