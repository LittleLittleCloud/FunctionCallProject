using Microsoft.ML.Copilot;
namespace FunctionCallProject
{
    public partial class Copilot3
    {
        /// <summary>
        /// say hello.
        /// </summary>
        /// <param name="name">caller name</param>
        [CopilotFunction]
        public async Task<string> SayHi(string name)
        {
            return $"Hello {name}";
        }

        /// <summary>
        /// calculate tax
        /// </summary>
        /// <param name="rate">tax rate</param>
        /// <param name="price">price</param>
        [CopilotFunction]
        public async Task<string> CalculateTax(float price, float rate = 0.05f)
        {
            return (price * rate).ToString();
        }

        /// <summary>
        /// calculate shipping
        /// </summary>
        [CopilotFunction]
        public async Task<string> CalcuateShipping(float price)
        {
            if (price > 100)
            {
                // free!
                return "Price over 100, You get free shipping! It usually takes 2~3 days to arrive.";
            }
            else
            {
                return "shipping fee is $8. It usually takes 2~3 days to arrive.";
            }
        }
    }
}
