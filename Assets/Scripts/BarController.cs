using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarController : MonoBehaviour
{
    public Slider progressBar; // Barı temsil eden UI Slider
    public float decreaseRate = 0.1f; // Zamanla azalma hızı
    public float increaseAmount = 0.2f; // Collectible alındığında artış miktarı
    public GameObject hideableObject;

    void Start()
    {
        // Başlangıçta barın değerini 1.0 olarak ayarla (tam dolu)
        progressBar.value = 1.0f;
    }

    void Update()
    {
        // Zamanla azalma
        DecreaseBar();

          if (progressBar.value <= 0)
        {
            hideableObject.SetActive(false);
        }

        // Barın değeri arttığında gizlenen objeyi görünür yap
        if (progressBar.value > 0 && hideableObject.activeSelf == false)
        {
            hideableObject.SetActive(true);
        }
    }
    

    void DecreaseBar()
    {
        // Zamanla azalma işlemi
        progressBar.value -= decreaseRate * Time.deltaTime;
    }

    public void CollectibleCollected()
    {
        // Collectible alındığında barı arttırma işlemi
        progressBar.value += increaseAmount;

        // Bar değeri 1.0'den büyükse sıfırla (tam dolu olması durumu)
        if (progressBar.value > 1.0f)
        {
            progressBar.value = 1.0f;
        }
    }
}