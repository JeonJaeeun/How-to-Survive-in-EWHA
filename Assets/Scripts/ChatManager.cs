using UnityEngine;

class ChatManager : MonoBehaviour
{
    public static ChatManager manager;
    public bool main = false;
    public bool ecc = false;

    private void Awake() {
        if(manager == null)
        {
            manager = this;
            ecc = false;
            main = false;
            DontDestroyOnLoad(this.gameObject);
        }
        else if(manager != this)
        {
            Destroy(this.gameObject);
        }
    }
}