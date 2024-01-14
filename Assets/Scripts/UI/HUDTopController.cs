using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDTopController : MonoBehaviour
{
    [SerializeField]
    private GameObject BannerObj;
    [SerializeField]
    private Text BannerTxtObj;
    [SerializeField]
    private float TopYPosition;
    [SerializeField]
    private float BotYPosition;

    private bool FallFlag = false;
    private BannerState bannerState = BannerState.UP;
    private string BannerTxtValue = "Your Turn";

    [SerializeField]
    private ParticleSystem BloodEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bannerState == BannerState.UP)
        {
            DropInCanvas();
        }
        else
        {
            PullUpCanvas();
        }
    }

    public void TriggerBanner(string NewText)
    {
        bannerState = BannerState.DOWN;
        //TODO: Change when gamestate system is able to pass current phase.
        if (BannerTxtValue == "Your Turn")
        {
            BannerTxtValue = "Enemy Turn";
        }
        else
        {
            BannerTxtValue = "Your Turn";
        }
        FallFlag = false;
    }

    private void DropInCanvas()
    {
        Vector3 canvasPos = BannerObj.transform.localPosition;
        if (canvasPos.y < BotYPosition - 4)
        {
            FallFlag = true;
        }
        if (FallFlag) { 
            BannerObj.transform.localPosition = new Vector3(canvasPos.x, Mathf.Lerp(canvasPos.y, BotYPosition, Time.deltaTime * 16));
        }
        else
        {
            BannerObj.transform.localPosition = new Vector3(canvasPos.x,Mathf.Lerp(canvasPos.y, BotYPosition-6, Time.deltaTime / ((canvasPos.y - BotYPosition)/400)));

        }
    }

    public void PullUpCanvas()
    {
        Vector3 canvasPos = BannerObj.transform.localPosition;
        if (canvasPos.y < TopYPosition)
        {
            BannerObj.transform.localPosition = new Vector3(canvasPos.x, Mathf.Lerp(canvasPos.y, TopYPosition, Time.deltaTime * 16));
        }
        if (canvasPos.y >= TopYPosition - 3 && canvasPos.y <= TopYPosition + 3)
        {
            //TODO: setText
            BannerTxtObj.text = BannerTxtValue;
            bannerState = BannerState.UP;
            BloodEffect.gameObject.active = false;
            BloodEffect.gameObject.active = true;
        }
    }
}

public enum BannerState
{
    UP,
    DOWN
}