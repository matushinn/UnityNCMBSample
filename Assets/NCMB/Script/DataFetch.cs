using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;


public class DataFetch : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //スコアが１０より大きいプレイヤーデータを取得する
        FetchScoreList(10);
	}
	
    private void FetchScoreList(int higherThan){

        //複数のNCMBObjectを取得するクエリを生成
        NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject>("PlayerData");

        //条件設定
        query.FindAsync((List<NCMBObject> objList, NCMBException e) =>
        {
            if (e != null)
            {
                //エラー処理
            }
            else
            {
                //成功時の処理
                foreach (NCMBObject obj in objList)
                {
                    Debug.Log("PlayerName:" + obj["PlayerName"] + ",Score:" + obj["Score"] + ",Coin:" + obj["Coin"]);
                }
            }
        });
    }
}
