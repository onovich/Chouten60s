using System;
using UnityEngine;

namespace Chouten {

    [CreateAssetMenu(fileName = "SO_Role", menuName = "Chouten/RoleTM")]
    public class RoleTM : ScriptableObject {

        public int typeID;
        public string typeName;
        public AllyStatus allyStatus;
        public float moveSpeed;
        public float attackDistance;
        public int skillTotalFrame;
        public int damageFrame;
        public int leavingTotalFrame;
        public int hpMax;
        public RoleMod mod;
        public GameObject deadVFX;
        public float deadVFXDuration;
        
    }

}