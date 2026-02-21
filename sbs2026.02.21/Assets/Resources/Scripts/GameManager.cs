using System;
using System.Globalization;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public enum RSPInfo
{
    Rock,
    Scissors,
    Paper
}

public class GameManager : MonoBehaviour
{
    public Sprite Win;
    public Image Defult;
    public Sprite Lose;
    public Sprite draw;

    public TextMeshProUGUI MyRSP;
    public TextMeshProUGUI EnemyRSP;
    public static GameManager Instance; 

    public RSPInfo enemyInfo;
    public bool bEnemyTurnState = false;

    // �÷��̾��� ü��

    private void Awake()
    {
        Instance = this;
    }

    public enum GameFlowInfo
    {
        PlayerTurn,
        EnemyTurn,
    }

    private void SelectEnemyInfo()
    {
        int rValue = UnityEngine.Random.Range(0, 3);

        enemyInfo = (RSPInfo)rValue;

        bEnemyTurnState = false;
    }

    public void PlayGame(GameFlowInfo EGF)
    {
        switch (EGF)
        {
            case GameFlowInfo.PlayerTurn:

                // �÷��̾��� ��ư�� ��ٸ���.

                break;
            case GameFlowInfo.EnemyTurn:

                bEnemyTurnState = true;
                SelectEnemyInfo();

                break;
            default:
                break;
        }
    }

    // ����(0) -> ����(1) -> ��(2)

    public void GameResult(RSPInfo playerInfo)
    {
        // round++

        if(playerInfo == RSPInfo.Rock)
        {
            if(enemyInfo == RSPInfo.Rock)
            {
                Debug.Log("비김.");
                Defult.sprite = draw;
                MyRSP.text = "바위";
                EnemyRSP.text = "바위";
            }
            else if(enemyInfo == RSPInfo.Scissors)
            {
                Debug.Log("이김.");
                Defult.sprite = Win;
                MyRSP.text = "바위";
                EnemyRSP.text = "가위";
            }
            else if((enemyInfo == RSPInfo.Paper))
            {
                Debug.Log("패배.");
                Defult.sprite = Lose;
                MyRSP.text = "바위";
                EnemyRSP.text = "보";
            }
        
        if(playerInfo == RSPInfo.Scissors)
        {
            if(enemyInfo == RSPInfo.Scissors)
            {
                Debug.Log("비김.");
                Defult.sprite = draw;
                MyRSP.text = "가위";
                EnemyRSP.text = "가위";
            }
            else if(enemyInfo == RSPInfo.Paper)
            {
                Debug.Log("이김.");
                Defult.sprite = Win;
                MyRSP.text = "가위";
                EnemyRSP.text = "보";
            }
            else if(enemyInfo == RSPInfo.Rock)
            {
                Debug.Log("패배.");
                Defult.sprite = Lose;
                MyRSP.text = "가위";
                EnemyRSP.text = "바위";
            }
        }
    }
    }
}