using AgentChat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionCallProject
{
    public partial class ExampleFunctionCall
    {
        /// <summary>
        /// example function call
        /// </summary>
        /// <param name="input">input</param>
        [FunctionAttribution]
        public async Task<string> ExampleFunctionCallAsync(string input)
        {
            return input;
        }
    }
}
