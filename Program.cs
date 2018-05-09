using System;
using Microsoft.ClearScript.JavaScript;
using Microsoft.ClearScript.V8;

namespace CScharpExecuteJavascript
{
    class Program
    {
        // Full doc: https://github.com/Microsoft/ClearScript
        static void Main(string[] args)
        {
            var taskA = new Task("TaskA", 54, 0.74m, 0.24m);
            var taskB = new Task("TaskB", 72, 0.74m, 0.24m);

            // create a script engine
            using (var engine = new V8ScriptEngine())
            {
                const string evaluateSetupJsFunction = @"
                function getSetup(previousTask, currentTask) {
                    var previousTaskSetup = previousTask.Quantity * previousTask.BeeingFirstPenaltyFactor;
                    var currentTaskSetup = currentTask.Quantity * currentTask.BeeingSecondPenaltyFactor;

                    return {
                        previousTaskSetup: previousTaskSetup,
                        currentTaskSetup: currentTaskSetup
                    }
                }";

                // call a script function
                engine.Execute(evaluateSetupJsFunction);
                var setupTimes = engine.Script.getSetup(taskA, taskB);

                Console.WriteLine($"{ taskA.Number } setup time: {setupTimes.previousTaskSetup}h");
                Console.WriteLine($"{ taskB.Number } setup time: {setupTimes.currentTaskSetup}h");

            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
