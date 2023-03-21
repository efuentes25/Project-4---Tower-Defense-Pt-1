using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class MoneyUI : MonoBehaviour
{
    public TextMeshProUGUI moneyText;
    void Start()
    {
        
    }

    void Update()
    {
        moneyText.text = "$" + PlayerStats.Money.ToString();
    }
}
