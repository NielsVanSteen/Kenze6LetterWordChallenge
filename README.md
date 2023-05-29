# 6LetterWordChallenge
Niels Van Steen
niels.van.steen@hotmail.com

## Info
1. Project uses .NET 7
2. The solution has 2 projects, 1 for the unit tests (Unit Test Project), and the other for the actual challenge (Console App Project). After cloning the repository just run Program.cs.
3. The input.txt file is located in the default directory used when running the program in debug mode: \Kenze6LetterWordChallenge\Kenze6LetterWordChallenge\bin\Debug\net7
4. The text file for the unit tests is also located in the /bin/Debug/... folder of the unit test project.
5. I excluded the /bin/Debug folder from the .gitignore so the input.txt file should still be there. If not (or when not running the project in debug mode) edit the path in Program.cs or paste the input.txt file there.


## 2nd Push
When I was laying in bed and thinking about a challenge a bit I realised I didn't follow the instructions 100%, for example given the word 'zambia' in the text file my first implementation of the interface 'IWordFinder' would only find one combination for the word zambia. 
So I used the logic al already had and made a new implementation of the 'IWordFinder' interface that would print all the different possibilities for 'zambia'. I also took a different approach and increased the performance.