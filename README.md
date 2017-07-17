# Code_Test_Sujish_TextComparer
Code Test: Text Matching Problem

Introduction

Spend as much time as required on to solve the problem. No time limit is applied.

Write the code in your usual style, using C#. Do not use built-in language functionality to directly solve the problem.

For example, do not use the built-in pattern matching functionality such as:

String::split(), String::indexOf(), String::lastIndexOf(), String::substring(), Regex.Match(), etc…

The solution should provide this functionality if applicable. You may use the String class to hold information while your own algorithm does the matching.

Note: String functions not related to matching can used.

You may choose any means of accepting input and producing output, including the use of a test harness.

Please return the completed code in a zip file named CODE_TEST_<Candidate Name>.zip

Requirements

Write an application that fulfils the following requirements:

1.	Accepts two strings as input: one string is called "text" and the other is called "subtext" in this problem statement,
2.	Matches the subtext against the text, outputting the character positions of the beginning of each match for the subtext within the text.
3.	Allows multiple matches
4.	Allows case insensitive matching

Acceptance Criteria

The input text is: Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea

Subtext:		Polly
Output:			1, 26, 51								

Subtext: 		polly
Output: 		1, 26, 51								

Subtext: 		ll
Output: 		3, 28, 53, 78, 82							

Subtext: 		Ll
Output: 		3, 28, 53, 78, 82							

Subtext: 		X
Output: 		<no matches>								

Subtext: 		Polx
Output: 		<no matches>								
