using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameloop : MonoBehaviour
{
    public RectTransform winston;
    public RectTransform sadie;
    public RectTransform vera;
    public GameObject battle;
    // Start is called before the first frame update
    void Start()
    {
        winston.anchoredPosition = new Vector2(winston.anchoredPosition.x,-175);
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
