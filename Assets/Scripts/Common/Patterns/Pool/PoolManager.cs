using UnityEngine;

public class PoolManager : Singleton<PoolManager> {
    
    //public Pool _Pool { get; private set; }

    private void Awake()
    {
        //_Pool = InitPool(TagEnum._Pool);
    }

    private static Pool InitPool(TagEnum tagEnum)
    {
        var pool = GameObject             
            .FindGameObjectWithTag(TagUtils.GetTagNameByEnum(tagEnum))
            .GetComponent<Pool>();
        pool.Init();
        return pool;
    }
}
