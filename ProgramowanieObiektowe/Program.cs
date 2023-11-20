

using ProgramowanieObiektowe.Extensions;

string text = "TestText";
text = text.AddExtraLine();
Console.WriteLine(text);

string textExtra = "TestText";
textExtra = textExtra.AddExtraLineWithText("NAPIS AUU");
Console.WriteLine(textExtra);