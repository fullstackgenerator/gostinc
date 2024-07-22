# gostinc


##Dipping my toes into C# with my first console app.

I picked up the C# Player's guide by Rb Whitaker, went through the first nine chapters/levels and was really impressed with the switch expressions. At about the same time I stumbled on a video by expert C# developer and youtuber, Tim Corey, on how to improve the language learning process.

###The main takeaways for me were the following:

1) Repeat exercises several times, preferably under different approaches.
2) Keep it short and sweet, don't complicate, make it easy to understand.
3) Realize it's not going to be perfect, especially your first code.

With that being said, allow me to describe my creation.

The original challenge [Buying Inventory](https://csharpplayersguide.com/solutions/4th-edition/buying-inventory) uses switch statements or switch expressions on a small inventory list. In order to successfully finish the task, you need to > build something to report the prices of various pieces of equipment, based on the user's selection.

What I did was turn the original list into a pizza restaurant menu, added two more lists (one for extras such as toppings, the other for drinks) and prices for each list. The next bit required adding two variables for tax (`9.5%` for food and `22%` for drinks).

Before being able to put everything together and presenting the user the full price, one more obstacle had to be dealt with. The pizza price list variable was an `int`, the extras and drinks variable a `double`, and the tax variable a `decimal`.

In order to get the correct price, all variables had to be changed to `decimal`. Lastly using the `Math.Round` method the final price was rounded down to two digits.