using UnityEngine;

public class MouseController : MonoBehaviour
{
    [SerializeField]
    private Transform character;    //キャラクターをInspectorウィンドウから選択してください
    [SerializeField]
    private Transform pivot;    //キャラクターの中心にある空のオブジェクトを選択してください
    public GameObject switch1;
    

    void Start()
    {
        //エラーが起きないようにNullだった場合、それぞれ設定
        if (character == null)
            character = transform.parent;
        if (pivot == null)
            pivot = transform;

   //   switch1.SetActive(false);
    }
    //カメラ上下移動の最大、最小角度です。Inspectorウィンドウから設定してください
    [Range(-0.999f, -0.5f)]
    public float maxYAngle = 10f;
    [Range(0.5f, 0.999f)]
    public float minYAngle = 0.5f;
    // Update is called once per frame
    void Update()
    {
        if (switch1.activeSelf)
        {
           
            //マウスのX,Y軸がどれほど移動したかを取得します
            float X_Rotation = Input.GetAxis("Mouse X") ;
       //   float Y_Rotation = Input.GetAxis("Mouse Y");
            //Y軸を更新します（キャラクターを回転）取得したX軸の変更をキャラクターのY軸に反映します
            character.transform.Rotate(0, X_Rotation, 0);
       //  character.transform.Rotate(0, Y_Rotation, 0);

            //次はY軸の設定です。
            float nowAngle = pivot.transform.localRotation.x;
            //最大値、または最小値を超えた場合、カメラをそれ以上動かない用にしています。
            //キャラクターの中身が見えたり、カメラが一回転しないようにするのを防ぎます。
        }
    }
}