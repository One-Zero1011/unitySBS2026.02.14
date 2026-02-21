using UnityEngine;

public class Player : MonoBehaviour
{
    
    public void SelectR()
    {
        GameManager.Instance.PlayGame(GameManager.GameFlowInfo.EnemyTurn);

        // GameManager 안에서 플레이어의 RSP 결정이 된다.

        GameManager.Instance.GameResult(RSPInfo.Rock);

    }

    public void SelectS()
    {
        GameManager.Instance.PlayGame(GameManager.GameFlowInfo.EnemyTurn);

        // GameManager 안에서 플레이어의 RSP 결정이 된다.

        GameManager.Instance.GameResult(RSPInfo.Scissors);

    }

    public void SelectP()
    {
        GameManager.Instance.PlayGame(GameManager.GameFlowInfo.EnemyTurn);

        // GameManager 안에서 플레이어의 RSP 결정이 된다.

        GameManager.Instance.GameResult(RSPInfo.Paper);

    }

}
