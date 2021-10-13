using UnityEngine;
using UnityEngine.UI;

public class BadShop : MonoBehaviour
{
    [SerializeField] private GameObject[] models;
    [SerializeField] private int[] price;
    [SerializeField] private Text[] priceText;
    [SerializeField] private GameObject[] buyButtons;

    [SerializeField] private int coins;
    [SerializeField] private Text coinsText;

    public void BuyModels(int index)
    {
        if (coins >= price[index])
        {
            foreach (GameObject m in models)
            {
                m.SetActive(false);
            }

            models[index].SetActive(true);
            priceText[index] = null;
            buyButtons[index].SetActive(false);

            coins = coins - price[index];
            coinsText.text = coins.ToString();
        }
    }

    public void LookAndSelectModels(int index)
    {
        foreach (GameObject m in models)
        {
            m.SetActive(false);
        }

        models[index].SetActive(true);
    }
}