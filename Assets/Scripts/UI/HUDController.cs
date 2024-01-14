using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    [SerializeField]
    private Image BloodFillBar;
    [SerializeField]
    private Text TxtBloodValue;
    [SerializeField]
    private int _targetBloodValue = 10;

    [SerializeField]
    private GameObject[] ManaObjs;

    private int ManaTotal = 0;
    private int CurrentMana = 0;

    [SerializeField]
    private Sprite Mana_Img;
    [SerializeField]
    private Sprite UsedMana_Img;

    private void Start()
    {
        //TODO: Subscribe to the "Take damage" event?
        //TODO: Subscribe to "New Turn" event

    }
    void Update()
    {
        LERPFillBar();
        LERPBloodValue();
    }

    public void UseMana(int amountUsed)
    {
        for(int i = 0; i < amountUsed; i++)
        {
            ManaObjs[CurrentMana-1-i].GetComponent<Image>().sprite = UsedMana_Img;
        }
        CurrentMana -= amountUsed;
    }

    public void NewTurn()
    {
        if (ManaTotal < 6) ManaTotal++;
        EnableManaNodes();
        CurrentMana = ManaTotal;
    }

    private void EnableManaNodes()
    {
        for (int i = 0; i < ManaTotal; i++)
        {
            ManaObjs[i].active = true;
            ManaObjs[i].GetComponent<Image>().sprite = Mana_Img;
        }
    }

    public void AddBlood(int value)
    {
        _targetBloodValue += value;
    }

    private void LERPFillBar()
    {
        float fillTarget = _targetBloodValue / 100f;
        if (BloodFillBar.fillAmount != fillTarget)
        {
            BloodFillBar.fillAmount = Mathf.Lerp(BloodFillBar.fillAmount, fillTarget, Time.deltaTime / (Distance(BloodFillBar.fillAmount, fillTarget) * 3));
        }
    }
    private void LERPBloodValue()
    {
        TxtBloodValue.text = string.Format("{0}", Mathf.RoundToInt( BloodFillBar.fillAmount * 100 ));
    }

    private float Distance(float a, float b)
    {
        if (a > b)
        {
            return a - b;
        }
        else
        {
            return b - a;
        }
    }
}
