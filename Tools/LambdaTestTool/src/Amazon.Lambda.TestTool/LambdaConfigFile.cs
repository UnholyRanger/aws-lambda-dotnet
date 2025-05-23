using System;
using System.Text.Json.Serialization;


namespace Amazon.Lambda.TestTool
{
    public class LambdaConfigFile
    {
        public string Framework { get; set; }
        public string Profile { get; set; }
        public string Region { get; set; }
        public string Template { get; set; }

        [JsonPropertyName("function-handler")]
        public string FunctionHandler { get; set; }
        [JsonPropertyName("function-name")]
        public string FunctionName { get; set; }
        [JsonPropertyName("function-timeout")]
        public int? FunctionTimeOut { get; set; }
        [JsonPropertyName("function-debugtimeout")]
        public int? FunctionDebugTimeOut { get; set; }

        [JsonPropertyName("image-command")]
        public string ImageCommand { get; set; }

        [JsonPropertyName("environment-variables")]
        public string EnvironmentVariables { get; set; }

        public string ConfigFileLocation { get; set; }

        public string DetermineHandler()
        {
            if (!string.IsNullOrEmpty(this.FunctionHandler))
                return this.FunctionHandler;

            return this.ImageCommand;
        }
    }
}
