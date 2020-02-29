# FizzBuzz

### S.Matthews 2020-02-29 V1.0.0

## Requirements as stated

_FizzBuzz is a children's game to teach multiples of n_

_Test:_

* You have a set of integers, 1 to 100
* I want you to cycle through this set lowest to highest
* For each number found that is evenly divisible by 3, output the word "Fizz"
* For each number that is evenly divisible by 5, output the word "Buzz"
* For each number that is evenly divisible by 3 AND 5, output the word "FizzBuzz"
* For each number that is not evenly divisible by 3 OR 5 output the number

## VS Solution

The solution was coded in Visual Studio 2019 Version 16.4.5 and comprises two projects; _FizzBuzz_ which is a .NET Framework 4.8 Console Application and _FizzBuzz.Testing_ which is a C# Unit Test Project.

### FizzBuzz Configuration & Dependencies

_FizzBuzz_ provides the user with the ability to control it's behaviour and output in a number of ways.  Firstly, from within the __App.Config__ file the following keys can be amended;

* __StartAt__ allows the user to key an integer value which specifies the first number in the sequence.  By default this is 1 and in the event that this key is not present or not valid within the configuration file, _FizzBuzz.exe_ will fall back to default.
* __LoopCount__ allows the user to define how many __Itterations__ _FizzBuzz.exe_ will loop through.  This is not the ceiling value at which to stop but the number of increments to make to the StartAt value.  Only when the StartAt value is 1 will the celing value equal the LoopCount value.  This value is always an "increment to" value so if a negative number of specified, it will be converted to it's positive equivelent.  By __default__ this is __100__ and in the event that this key is not present or not valid within the configuration file, _FizzBuzz.exe_ will fall back to default.
* __ReplacementsLocation__ specifies the location and filename of the JSON control file which contains the list of replacement phrases and values to which they are assigned.  More information is contained below.

_FizzBuzz_ has project dependencies on Microsoft .NET Framework Version 4.8, Newtonsoft.JSON Version 12.0.3

_FizzBuzz.Testing_ has project dependencies on Microsoft .NET Framework Version 4.8 and a clean build of Fizzbuzz.proj

__Replacement Locations JSON file__

__Fizzbuzz.exe__ requires, at runtime, a JSON file which contains the configuration information for which numbers each itterative result ought to be divided by and in the case it is evenly divisible, the word which ought to replace that number in the final output.  NOTE: The order in which the JSON objects appear is crucial to correct output as, when a number is divisible by more than one value, the replacement output will be appended in the order in which it appears in the JSON file.  JSON order is an accepted behaviour under [RFC 7159](https://tools.ietf.org/html/rfc7159).

The location and filename of the replacement location file may be modified via the _ReplacementLocation_ key in the app.config file (see above) but the format of the JSON file must follow the example; _[ { "Denominator": 3 , "Replacement" : "Fizz" } , { "Denominator": 5 , "Replacement" : "Buzz"} ]_

The absence of this file or an incorrectly configured location will mean that __FizzBuzz__ will simply return each number of the sequence without attempting any replacement.  _FizzBuzz.Testing_ does not use or require this JSON file as it is effectively mocking it's own FizzBuzz word replacement list at test runtime.
