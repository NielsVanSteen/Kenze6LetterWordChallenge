# 6LetterWordChallenge
Niels Van Steen
niels.van.steen@hotmail.com

## Info
1. Project uses .NET 7
2. The input.txt file is located in the default directory used when running the program in debug mode: \Kenze6LetterWordChallenge\Kenze6LetterWordChallenge\bin\Debug\net7
3. The text file for the unit test is also located in the /bin/Debug/... folder of the unit test project.
4. I excluded the /bin/Debug folder from the .gitignore so the input.txt file should still be there. If not edit the path in Program.cs or paste the input.txt file there.


## 2nd Push
When I was laying in bed and thinking about a challenge a bit I realised I didn't follow the instructions 100%, for example given the word 'zambia' in the text file my first implementation of the interface 'IWordFinder' would only find one combination for the word zambia. 
So I used the logic al already had and made a new implementation of the 'IWordFinder' interface that would print all the different possibilities for 'zambia'. I also took a different approach and increased the performance.