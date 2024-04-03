using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CubeContorller : MonoBehaviour
{
    public Transform lookAtTarget;
    // Start is called before the first frame update
    void Start()
    {
        /*
        transform.DOLocalMove(new Vector3(10f, 0, 0), 1f) //直線移動(減速して止まる)
            //.SetEase(Ease.Linear);//等速にする
            .SetEase(Ease.InBack);//少し後ろ見下がってから直線移動
        */
        //transform.DOLocalRotate(new Vector3(180f,45f,-100f),2f);//回転
        //360度以上の回転は第三引数が必要
        //transform.DOLocalRotate(new Vector3(0,360f,0),2f,RotateMode.FastBeyond360);//回転
        //
        //transform.DOLookAt(lookAtTarget.localPosition, 1f);//指定の座標を向かせる
        //transform.DOLocalMove(new Vector3(10f, 0, 0), 1f)
        /*
        .SetDelay(2f); //2秒ディレイする(待機する)
        .SetLoops(3, LoopType.Yoyo) //イージング設定
        .SetEase(Ease.InOutQuart); //繰り返し設定
        .OnComplete(MyCompleteFunction);
        */
        StartCoroutine(MyMove());
    }
    void MyCompleteFunction(){
        Destroy(lookAtTarget.gameObject);
    }
    IEnumerator MyMove(){
        transform.DOLocalMove(lookAtTarget.position,4f);
        yield return new WaitForSeconds(1f);
        transform.DOComplete();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
