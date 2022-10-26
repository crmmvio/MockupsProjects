
//Reference Article: https://www.codeproject.com/Tips/1236704/Reducing-the-string-Length-of-a-Guid
using System;

var newGuid = Guid.NewGuid();

Console.WriteLine($"GUID: {newGuid.ToString()}");
Console.WriteLine($"length: {newGuid.ToString().Length}");

var base64 = Convert.ToBase64String(newGuid.ToByteArray());
Console.WriteLine($"Base64 representation: {base64}");
Console.WriteLine($"length: {base64.Length}");

var reconstructedGuid = new Guid(Convert.FromBase64String(base64));
Console.WriteLine($"Restored GUID: {reconstructedGuid.ToString()}");
Console.WriteLine("Restore from Base64 : " + (reconstructedGuid == newGuid ? "PASSED" : "FAILED"));