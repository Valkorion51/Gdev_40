using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{

    public int Money;
    public int Score12;
    private int MoneyUp = 1;
    private int ScoreUp = 1;

    private bool Check = true;

    public Text MoneyText;
    public GameObject ShopPan;
    public Text Score;

    void Update()
    {
        MoneyText.text = Money + "exp";
        Score.text = "Score: " + Score12;
    }

    public void OnClickButton()
    {
        Money += MoneyUp;
        Score12 += ScoreUp;
    }

    public void OnClickShopButton()
    {
        if(Check == true)
        {
            ShopPan.SetActive(true);
            Check = false;
        }
        else
        {
            ShopPan.SetActive(false);
            Check = true;
        }
    }

    public void OnClickBuy1()
    {
        if(Money >= 100)
        {
            MoneyUp *= 2;
            Money -= 100;
            ScoreUp *= 4;
        }
    }

    public void OnClickBuy2()
    {
        if (Money >= 200)
        {
            MoneyUp *= 4;
            Money -= 200;
            ScoreUp *= 8;
        }
    }

    public void OnClickBuy3()
    {
        if (Money >= 500)
        {
            MoneyUp *= 8;
            Money -= 500;
            ScoreUp *= 16;
        }
    }
}
