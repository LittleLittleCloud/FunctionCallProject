using CopilotBuilder;
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
        /// example function call blablabl
        /// </summary>
        /// <param name="input">input</param>
        [CopilotFunction]
        public async Task<string> ExampleFunctionCallAsync(string input)
        {
            return input;
        }

        /// <summary>
        /// example functions blabla
        /// </summary>
        /// <param name="input">inputsfsdf</param>
        [CopilotFunction]
        public async Task<string> ExampleFunctionCall2Async(string input)
        {
            return input;
        }
    }
}
