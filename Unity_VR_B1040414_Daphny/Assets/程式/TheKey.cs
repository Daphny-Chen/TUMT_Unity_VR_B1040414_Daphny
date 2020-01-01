using UnityEngine;

public class TheKey : MonoBehaviour {



    public void ThrowPickUp()
    {
        print("撿起物件");
    }
    public void ThrowDetach(GameObject obj)
    {
        print("放開物件");
        Destroy(obj);
    }
    public void ThrowHeld()
    {
        print("拿住物件");
    }
}
