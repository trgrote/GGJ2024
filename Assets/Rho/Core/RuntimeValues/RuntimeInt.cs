using UnityEngine;

namespace rho
{
    [CreateAssetMenu(fileName = "RuntimeIntValue", menuName = "Rho/RuntimeValues/Int")]
    public class RuntimeInt : RuntimeValue<int>
    {
        public void ModValue(int amount)
        {
            Value += amount;
        }
    }
}