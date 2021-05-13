using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

public class MoveScript : MonoBehaviour
{

    Player _player;
    int playerId  = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
   {
      _player = ReInput.players.GetPlayer(playerId);
   }

    // Update is called once per frame
    void Update()
    {
        if(_player.GetAxis("MoveHorizontal"){
         Debug.log("MoveHorizontal");
      }
    }
}
