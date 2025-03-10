using UnityEngine;
using UnityEngine.UI;


public class ShowFlavorOne : MonoBehaviour
{
    public ShowCake showCake;
    public ShowCreamOne showCreamOne;
    public ShowCreamTwo showCreamTwo;
    public int clickOne = 0;
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

    public void MakeFlavorOne()
    {

        if(showCreamOne.clickOne != 0 || showCreamTwo.clickTwo != 0)//krema koymadan süsleme konulamaz
        {
            clickOne++;

        if(cakeToShowFirst.gameObject.activeSelf && !cakeToShowSecond.gameObject.activeSelf && !cakeToShowThird.gameObject.activeSelf)
        {
            fotsOne.gameObject.SetActive(true);
            fotsTwo.gameObject.SetActive(false);
            fotsThree.gameObject.SetActive(false);
            fttsOne.gameObject.SetActive(false);
            fttsTwo.gameObject.SetActive(false);
            fttsThree.gameObject.SetActive(false);
            ftitsOne.gameObject.SetActive(false);
            ftitsTwo.gameObject.SetActive(false);
            ftitsThree.gameObject.SetActive(false);   
        }
        if(cakeToShowFirst.gameObject.activeSelf && cakeToShowSecond.gameObject.activeSelf && !cakeToShowThird.gameObject.activeSelf)
        {
            fotsOne.gameObject.SetActive(false);
            fotsTwo.gameObject.SetActive(true);
            fotsThree.gameObject.SetActive(false);
            fttsOne.gameObject.SetActive(false);
            fttsTwo.gameObject.SetActive(false);
            fttsThree.gameObject.SetActive(false);
            ftitsOne.gameObject.SetActive(false);
            ftitsTwo.gameObject.SetActive(false);
            ftitsThree.gameObject.SetActive(false);  
        }
        if(cakeToShowFirst.gameObject.activeSelf && cakeToShowSecond.gameObject.activeSelf && cakeToShowThird.gameObject.activeSelf)
        {
            fotsOne.gameObject.SetActive(false);
            fotsTwo.gameObject.SetActive(false);
            fotsThree.gameObject.SetActive(true);
            fttsOne.gameObject.SetActive(false);
            fttsTwo.gameObject.SetActive(false);
            fttsThree.gameObject.SetActive(false);
            ftitsOne.gameObject.SetActive(false);
            ftitsTwo.gameObject.SetActive(false);
            ftitsThree.gameObject.SetActive(false);
        }
        }
    }
}
