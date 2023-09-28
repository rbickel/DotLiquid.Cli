using DotLiquid;
using DotLiquid.NamingConventions;
using System.Globalization;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using System.Dynamic;

// See https://aka.ms/new-console-template for more information
string templateFileName = args.Length > 0 ? args[0] : "template.liquid";
string dataFileName = args.Length > 1 ? args[1] : "data.json";

string templateString = File.ReadAllText(templateFileName);
string dataString = File.ReadAllText(dataFileName);

var jsonObj = JsonConvert.DeserializeObject<ExpandoObject>(dataString, new ExpandoObjectConverter());
var hash = Hash.FromDictionary(jsonObj);

Template.NamingConvention = new CSharpNamingConvention();

Template template = Template.Parse(templateString);
var output = template.Render(hash); 
Console.WriteLine(output);
