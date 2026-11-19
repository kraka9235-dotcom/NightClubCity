using UnityEngine;
public class GameManager : MonoBehaviour {
    public int coins = 1000;
    void Start() { Debug.Log("NightClubCity Started - Coins: " + coins); }
    public void AddCoins(int amount) { coins += amount; }
}
