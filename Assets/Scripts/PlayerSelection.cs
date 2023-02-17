using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerSelection : MonoBehaviour
{
    public PlayerData[] playerData;
    public Transform playerTransform;
    public GameObject nextButton;
    public GameObject previousButton;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI weightText;
    public TextMeshProUGUI strengthText;
    public TextMeshProUGUI breathText;
    public TextMeshProUGUI flightText;
    public TextMeshProUGUI damageText;
    public TextMeshProUGUI speedText;

    List<GameObject> gameObjects;

    int currentIndex = 0;
    void Start()
    {
        gameObjects = new List<GameObject>();

        foreach(PlayerData p in playerData)
        {
            GameObject player = Instantiate(p.playerPrefab, playerTransform.position, playerTransform.rotation);
            gameObjects.Add(player);
            player.SetActive(false);
        }

        ShowCurrentSelection();
    }

    void ShowCurrentSelection()
    {
        gameObjects[currentIndex].SetActive(true);
        nameText.text = "Name : " + playerData[currentIndex].name;
        weightText.text = "Weight : " + playerData[currentIndex].weight.ToString();
        strengthText.text = "Strength : " + playerData[currentIndex].strength.ToString();
        breathText.text = "Breath : " + playerData[currentIndex].breath;
        flightText.text = "Flight : " + playerData[currentIndex].flight;
        damageText.text = "Damage : " + playerData[currentIndex].damage.ToString();
        speedText.text = "Speed : " + playerData[currentIndex].speed.ToString();
    }

    public void NextSelection()
    {
        Debug.Log(currentIndex);
        if(currentIndex > 5)
        {
            nextButton.SetActive(false);
        }
        if( currentIndex <= gameObjects.Count)
        {
            previousButton.SetActive(true);
            gameObjects[currentIndex].SetActive(false);
            currentIndex++;
            ShowCurrentSelection();
        }
    }

    public void PreviousSelection()
    {
        if(currentIndex < 2)
        {
            previousButton.SetActive(false);
        }
        nextButton.SetActive(false);
        gameObjects[currentIndex].SetActive(false);
        currentIndex--;
        ShowCurrentSelection();
    }

}
