﻿using UnityEngine;
using TMPro;

public class CurrencyCounter : MonoBehaviour
{
    public static CurrencyCounter instance;

    public TMP_Text currencyText;
    public int currentCurrency;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        currencyText.text = "Currency: " + currentCurrency.ToString();
    }

    public void IncrementCurrency(int value)
    {
        currentCurrency += value;
        currencyText.text = "Currency: " + currentCurrency.ToString();
    }
}
