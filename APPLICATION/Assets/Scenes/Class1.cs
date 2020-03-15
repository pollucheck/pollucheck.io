using UnityEngine;
using System.Collections;

public class Class1 : MonoBehaviour
{
    public void URL()
    {
        Application.OpenURL("https://answers.unity.com/questions/1245858/use-a-button-to-open-a-web-browser.html");
        Debug.Log("is this working?");
    }
    public void URL1()
    {
        Application.OpenURL("https://www.icicibank.com/online-services/scan-to-pay/cards-payment.page");
        Debug.Log("is this working?");
    }
    public void URL2()
    {
        Application.OpenURL("https://www.bhimupi.org.in/");
        Debug.Log("is this working?");
    }
    public void URL3()
    {
        Application.OpenURL("https://paytm.com/");
        Debug.Log("is this working?");
    }

}