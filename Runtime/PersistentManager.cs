using PufferSoftware.EventSystem;

namespace PufferSoftware.Manager
{
    public class PersistentManager<T> : Manager<T> where T : Actor
    {
        protected override void Awake()
        {
            if (Instance != null)
            {
                Destroy(gameObject);
            }
            
            DontDestroyOnLoad(gameObject);
            base.Awake();
        }
    }
}