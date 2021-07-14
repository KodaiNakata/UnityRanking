using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankingView : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Type == Number �̏ꍇ
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(200);

        //// Type == Time �̏ꍇ
        //var millsec = 1;
        //var timeScore = new System.TimeSpan(0, 0, 0, 0, millsec);
        //naichilab.RankingLoader.Instance.SendScoreAndShowRanking(timeScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
