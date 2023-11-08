using FunctionCallProject;
using Microsoft.ML.Copilot;

var copilot3 = await ContosoDocumentAgent.CreateAgentAsync();
var reply = await copilot3.SendMessageAsync("what's return policy");

reply.PrettyPrintMessage();


