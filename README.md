# Green Stocks Analysis

## Purpose
The purpose of this project was to take code written to analyze stock performance in 2017 and 2018 and refactor it to improve the speed that the code ran. We were able to accomplish this by using a variable index to decrease the amount of looping required in the code. 

## Original Code

![Original Code](https://user-images.githubusercontent.com/88564212/133508442-e7eff3d5-3ac3-4a77-84b7-53882bd5418d.png)

As pictured above the original code used a nested for loop to iterate both the stock ticker and on the cell number to determine the starting price, ending price, and total return of each stock. This process was fairly fast on my computer, only taking about 1.25 to 1.5 seconds. As we add more stocks the time could start to be an issue. 

## Refactored Code

![Refactored](https://user-images.githubusercontent.com/88564212/133509002-ddb2dbd2-8591-4b2a-b5af-cce68c954314.png)


With the refactored code we use a for loop to establish a variable index referencing the ticket array. After this we can make the for loop to establish ticket volume much faster as it is only going through a single loop instead of nested. With this method we were able to get the run time of the code to ~.25 seconds.

## Advantages and Disadvantages of Refactoring 

Refactoring code can be a huge timesaver when ran against the right code. In some cases you run the risk of reinventing the wheel where it might not need it, spending more time than is saved overall on the refactoring. 

 In cases like the above referenced code that saw a over 75% decrease in time for relatively small time put in, it shows to be a huge gain. 
