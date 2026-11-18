
using UnityEngine;
public class FullGame : MonoBehaviour {
    public string[] servers = {"Morocco","Brazil","USA"};
    public void StartNightclubJob(string job){ Debug.Log("Working as "+job); }
    public void StartMission(int id){ Debug.Log("Mission "+id); }
    public void BuyExpensiveCar(string name, int coins){ Debug.Log("Bought "+name); }
}
