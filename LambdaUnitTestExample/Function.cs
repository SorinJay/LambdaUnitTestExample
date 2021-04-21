using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

using Amazon.Lambda.Core;


// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace LambdaUnitTestExample
{
    public enum Condition
    {
        EXCELLENT,
        GOOD,
        FAIR,
        BAD
    }


    public class Car
    {

        public string Make;
        public Condition Condition { get; private set; }
        public int speed;
     
        public int Speed {  get => speed; set => speed = value; }

        public Car(string make, Condition condition)
        {
            Make = make;
            Condition = condition;

        }


    }
}
