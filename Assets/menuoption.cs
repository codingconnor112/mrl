using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class menuoption : MonoBehaviour
{
    public Sprite activated;
    public Sprite deactivated;
    public Image selfimage;
    public bool selected;
    public bool mouse_selected=false;

    public GameObject up;
    public GameObject down;
    public GameObject left;
    public GameObject right;

    public GameObject dropoff;
    public string dropoffclass;
    public string classfunction;

    public bool selectbefore=false;
    public float startup = 1;
 
    // Start is called before the first frame update
    void Start()
    {
        selfimage = gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        mouse_selected = EventSystem.current.IsPointerOverGameObject();
        if (selected && Input.GetAxis("Vertical") == 1)
        {
            if (up != null)
            {
                selected = false;
                up.GetComponent<menuoption>().selected = true;
            }
        }
        if (selected && Input.GetAxis("Vertical") == -1)
        {
            if (down != null)
            {
                selected = false;
                down.GetComponent<menuoption>().selected = true;
            }
        }
        if (selected && Input.GetAxis("Horizontal") == 1)
        {
            if (right != null)
            {
                selected = false;
                right.GetComponent<menuoption>().selected = true;
            }
        }
        if (selected && Input.GetAxis("Horizontal") == -1)
        {
            if (left != null)
            {
                selected = false;
                left.GetComponent<menuoption>().selected = true;
            }
        }

        if (selected)
        {
            selfimage.sprite = activated;
        }
        else
        {
            selfimage.sprite = deactivated;
        }

        if (Input.GetAxisRaw("Submit")==1&&selectbefore&&startup==0)
        {
            if (selected)
            {
                dropoff.GetComponent(dropoffclass).SendMessage(classfunction);
            }
        }

        //float loudness=getloudnessfromaudioclip(Microphone.GetPosition(Microphone.devices[0]),Microphone.Start(Microphone.devices[0], true, 20, AudioSettings.outputSampleRate));
        
    }
    private void LateUpdate()
    {
        selectbefore = !(Input.GetAxisRaw("Submit") == 1);
    }
    private void FixedUpdate()
    {
        if (startup > 0)
        {
            startup -= 1;
        }
    }
    public float getloudnessfromaudioclip(int clipPosition, AudioClip clip)
    {
        int startposition = clipPosition - 60;
        float[] wavedata = new float[60];
        clip.GetData(wavedata, startposition);

        float totalLoudness = 0;
        for(int i = 0; i < 60; i++)
        {
            totalLoudness += Mathf.Abs(wavedata[i]);
        }

        return totalLoudness / 60;
    }
}
