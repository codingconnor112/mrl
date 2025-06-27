using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class gameloop : MonoBehaviour
{
    public RectTransform winston;
    public RectTransform sadie;
    public RectTransform vera;
    public GameObject battle;
    public TMP_Text flavortext;
    IEnumerator flavortextwait(string text)
    {
        flavortext.text = text;
        while (Input.GetAxisRaw("Submit") != 1)
        {
            yield return new WaitForFixedUpdate();
        }
        flavortext.text = "";
        winston.transform.Find("buttonset").gameObject.SetActive(true);
        winston.anchoredPosition = new Vector2(winston.anchoredPosition.x, -175);
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(flavortextwait("*Mr.L II is rolling around at the speed of sound"));
        
    }
    

    public void winstonfight()
    {
        winston.anchoredPosition = new Vector2(winston.anchoredPosition.x, -215);
        sadie.anchoredPosition = new Vector2(sadie.anchoredPosition.x, -175);
        winston.transform.Find("buttonset").gameObject.SetActive(false);
        sadie.transform.Find("buttonset").gameObject.SetActive(true);
    }
    public void sadiefight()
    {
        sadie.anchoredPosition = new Vector2(sadie.anchoredPosition.x, -215);
        vera.anchoredPosition = new Vector2(vera.anchoredPosition.x, -175);
        sadie.transform.Find("buttonset").gameObject.SetActive(false);
        vera.transform.Find("buttonset").gameObject.SetActive(true);
    }
    public void verafight()
    {
        vera.anchoredPosition = new Vector2(vera.anchoredPosition.x, -215);
        vera.transform.Find("buttonset").gameObject.SetActive(false);
        battle.SetActive(true);
    }
}
