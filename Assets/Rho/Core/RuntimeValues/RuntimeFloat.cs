using UnityEngine;

namespace rho
{
    [CreateAssetMenu(fileName = "RuntimeFloatValue", menuName = "Rho/RuntimeValues/Float")]
    public class RuntimeFloat : RuntimeValue<float>
    {
        public void ModValue(float amount)
        {
            Value += amount;
        }
    }
}