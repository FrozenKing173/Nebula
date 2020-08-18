# Code Challenge


Please see the attached CSV files. These files contain a client’s employee data as well as event detail for a single day from all relevant mobile vendors for SIMs owned by those employees. Please refer to these files when answering the following questions.


## Question 1

Using the files given, design a database that can store data of this nature. Send us the ERD of the proposed database in any format you prefer. Eliminate data redundancies where possible.


## Question 2

The company has decided to give each employee a company email. All current email addresses will be ported over, but the Host will change to “company”. As an example, please refer to Figure 1.

The email in Figure 1 will be updated to example@company.com. They need you to update the database to reflect this change.
Come up with a solution to update all employee email addresses accordingly. 
Please note*
*	Assume the table you are updating matches the attached employee file exactly. 
*	You can use any languages you like.
*	The domains must remain unchanged.


## Question 3

A newly written query is running slower than expected. The user wants to see how many tickets was sold in each genre over a specific period
Table Examples:
[Tickets] (Stores all the movie tickets sold) 
TicketID	Seat Number	MovieID
10	1A	1

[Movies] (Stores all the different Movies)
MovieID	Name	Genre
1	Citizen Kane	Drama


Pseudo code:
 
SELECT all the unique values in COLUMN [Movies].[Genres] 
       as well as a COUNT of [Tickets].[Number]
       
FROM TABLE [Tickets] (Stores all the movie tickets sold) and 

JOIN [Movies] (Stores all the different Movies) on to it to get the genre

It should only count WHERE the ticket purchase date falls in the specified timeframe

SQL example:

```sql
SELECT DISTINCT mov.[Genres], COUNT(tic.[Number])

FROM [Tickets] tic

JOIN [Movies] mov ON mov.[MovieID] = tic.[MovieID]

WHERE tic.[PurchaseDate] >= '2020-01-01' AND tic.[PurchaseDate] <= '2020-04-01'

GROUP BY mov.[Genres]
```

Please note:
*	The [Tickets] table has millions of rows.
*	The resulting data should be less than 30 rows.
*	Assume the query is written exactly as the pseudocode states and no extra mistakes are made.

Please answer any two of the following questions

Please describe how you would go about improving this query’s execution time.

OR

Please propose possible tests to determine the cause of the slow execution

OR

Please advise on database structure and design changes we can investigate to mitigate slow queries such as this


## Question 4

In the language of your choosing, write a method or script that takes an integer parameter and prints the next five Fibonacci numbers starting at that interval. Any possible errors should be handled.
