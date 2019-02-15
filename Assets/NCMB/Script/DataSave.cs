using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;


public class DataSave : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SavePlayerData("AAA", 100, 300);
	}
	
    public void SavePlayerData(string playerName,int score,int coin){
        NCMBObject obj = new NCMBObject("PlayerData");

        obj.Add("PlayerName", playerName);
        obj.Add("Score", score);
        obj.Add("Coin", coin);

        obj.SaveAsync((NCMBException e) =>
        {
            if (e != null)
            {
                //エラー処理
                Debug.Log("保存失敗");
            }
            else
            {
                //保存成功
                Debug.Log("保存成功");

            }
        });
    }
}
