using UnityEngine;
using UnityEngine.UI;

public class ShowCake : MonoBehaviour
{
    public ShowCreamOne showCreamOne;
    public ShowCreamTwo showCreamTwo;
    public ShowFlavorOne showFlavorOne;
    public ShowFlavorTwo showFlavorTwo;
    public ShowFlavorThree showFlavorThree;
    public Image cakeToShowFirst;
    public Image cakeToShowSecond;
    public Image cakeToShowThird;

    public int clickCount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cakeToShowFirst.gameObject.SetActive(false);
        cakeToShowSecond.gameObject.SetActive(false);
        cakeToShowThird.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void MakeCake()
    {
        clickCount++;

        if(showCreamOne.clickOne == 0 && showCreamTwo.clickTwo == 0)//krema koyduktan sonra kek konulamaz
        {

            if(!cakeToShowFirst.gameObject.activeSelf)
            {
                cakeToShowFirst.gameObject.SetActive(true);       
            }

            if(clickCount == 2 && cakeToShowFirst.gameObject.activeSelf)
            {
                cakeToShowSecond.gameObject.SetActive(true);
            }
            if(clickCount == 3 && cakeToShowSecond.gameObject.activeSelf)
            {
                cakeToShowThird.gameObject.SetActive(true);
            }
        }
    }
}
