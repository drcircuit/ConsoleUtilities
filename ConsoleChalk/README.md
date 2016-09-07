#Console Chalk
This is a set of extension methods that wraps the cumbersome methods of coloring text in the console output.
You use it by calling a color method on a string object, and that will set the color and call the console and reset the color again.
For convenience it returns an empty string, so that you may chain calls to color multiple texts.
Examples:
  --- cs
  Console.WriteLine("This text should be normal");
  ---
  Outputs: "This text should be normal" in the currently set console color.
  --- cs
  Console.WriteLine("Green".Green() + " should appear green");
  ---
  Outputs: "Green" in green color.
  --- cs
  Console.WriteLine("Blue".Blue(true) + "should appear blue on it's own line");
  ---
  Outputs: "Blue" in blue
  and "should appear blue on it's own line" on the next line
  --- cs
  Console.WriteLine($"{"Red".Red()} Should appear red, even though it's defined in an expression");
  ---
  Outputs: "Red" in red and " Should appear red, even though it's defined in an expression" in the regular console color.
  --- cs
  Console.WriteLine(" Writing " + "red".Red() + " in the middle of a string, sadly moves it first. Color calls are resolved first.");
  ---
  Outputs: "red" in red first, then "Writing  in the middle of a string, sadly moves it first. Color calls are resolved first."
  
  Since color calls go before the call to writeline, it outputs the colored text first, even though it appears in the middle of 
  concatenation.
  
  --- cs
  Console.WriteLine("However writing ".Gray() + "red".Red() + " in the middle of a chain of calls, works!".Gray());
  ---
  Outputs: "However writing " in gray and "red" in red and " in the middle of a chain of calls, works!" in gray.
  The previous example is fixed by concatenating a chain of calls, (not a dataflow chain..) but since you call "gray" it resolves in order.
  --- cs
  "Call red on a string, will render it in red".Red();
  ---
  Outputs: "Call red on a string, will render it in red" in red.
  You do not need to pass the output to Console.Writeline, the color methods wrap that for you. 
  Just be careful, do not use color methods on the other side of assignments. They will output string.empty, so the variable is assigned empty. Not the given value.
  
  --- cs
  string greeting = "Hello World!".Green();
  
  if(string.IsNullOrEmpty(greeting)){
    "How rude!".Red();
  }
  ---
  This will output "How rude!" in red, since "Hello World!".Green() returns string emtpy.
  but:
  --- cs
  string greeting = "Hello World!";
  greeting.Green();
  
  if(string.IsNullOrEmpty(greeting)){
    "How rude!".Red();
  }
  ---
  Will output "Hello World!" in green, and the program will not enter the if block.
