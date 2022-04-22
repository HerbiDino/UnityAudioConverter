using System.Collections.Generic;
using UnityEngine;

namespace HD.Audio
{
    public class HDAudioMixerSO : ScriptableObject
    {
        [field: SerializeField] public List<HDAudioEffectSO> Effects { get; private set; } = new List<HDAudioEffectSO>();
    }
}