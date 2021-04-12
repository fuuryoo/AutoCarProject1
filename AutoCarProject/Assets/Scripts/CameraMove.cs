using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;  //DOTween‚ðŽg‚¤‚Æ‚«‚Í‚±‚Ìusing‚ð“ü‚ê‚é



public class CameraMove : MonoBehaviour
{

    public GameObject target1;
    public GameObject target1_5;
    public GameObject target2;
    public GameObject target3;
    public GameObject target4;
    private Tween cameraMove = null;

    void Start()
    {



        // 3•b‚©‚¯‚Ä(5,0,0)‚ÖˆÚ“®‚·‚é
        //this.transform.DOMove(new Vector3(5f, 0f, 0f), 3f);
        
        var cameraMove = transform.DOPath(new Vector3[] { target1.transform.position, target1_5.transform.position, target2.transform.position, target3.transform.position, target4.transform.position, target1.transform.position }, 40f, PathType.Linear);
        //cameraMove.SetLoops(-1,LoopType.Yoyo);
        cameraMove.SetLookAt(0.03f);
    }

    private void Update()
    {
        


    }
}