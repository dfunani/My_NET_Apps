using System;
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json;

namespace CalculatorLibrary
{
    public class CalculatorOperations
    {
        JsonTextWriter writer;
        public CalculatorOperations()
        {
            StreamWriter jsonFile = File.CreateText("C:\\Users\\dfuna\\Documents\\GitHub\\My .Net Apps\\Calculator\\calculator.json");
            StreamWriter logFile = File.CreateText("C:\\Users\\dfuna\\Documents\\GitHub\\My .Net Apps\\Calculator\\calculator.log");
            Trace.Listeners.Add(new TextWriterTraceListener(logFile));

            Trace.AutoFlush = true;
            writer = new JsonTextWriter(jsonFile);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartObject();
            writer.WritePropertyName("History");
            writer.WriteStartArray();

            Trace.WriteLine("Starting Calculator Log");
            Trace.WriteLine(String.Format("Started {0}", System.DateTime.Now.ToString()));
        }

        public void CleanUp()
        {
            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.Close();
        }
        public double Arithmetic(double lhs, double rhs, string op)
        {
            double result = double.NaN;
            writer.WriteStartObject();
            writer.WritePropertyName("LHS");
            writer.WriteValue(lhs);
            writer.WritePropertyName("RHS");
            writer.WriteValue(rhs);
            writer.WritePropertyName("Operator");
            
            

            switch (op)
            {
                case "+":
                    result = (lhs + rhs);
                    Trace.WriteLine(String.Format("{0} + {1} = {2}", lhs, rhs, result));
                    writer.WriteValue(op);
                    break;
                case "-":
                    result = (lhs - rhs);
                    Trace.WriteLine(String.Format("{0} + {1} = {2}", lhs, rhs, result));
                    writer.WriteValue(op);
                    break;
                case "*":
                    result = (lhs * rhs);
                    Trace.WriteLine(String.Format("{0} + {1} = {2}", lhs, rhs, result));
                    writer.WriteValue(op);
                    break;
                case "/":
                    if (rhs != 0)
                    {
                        result = (lhs / rhs);
                        Trace.WriteLine(String.Format("{0} + {1} = {2}", lhs, rhs, result));
                        writer.WriteValue(op);
                    }
                    break;
            }
            writer.WritePropertyName("Result");
            writer.WriteValue(result);
            writer.WriteEndObject();
            return result;
        }
    } 
}
