using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Newtonsoft.Json.Bson;

public class moneymanager : MonoBehaviour
{
    public static int money;
    public static int turretPrice = 35;

    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI priceText;

    private void Start()
    {
        money = 50;
        turretPrice = 35;
    }

    private void Update()
    {
        moneyText.text = "$" + money.ToString();
        priceText.text = "TURRET PRICE: $" + turretPrice.ToString();
    }
}
