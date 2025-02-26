### **Gostinc - A Terminal-Based Ordering App**  

I picked up the *C# Player's Guide* by Rb Whitaker, went through the first nine chapters/levels, and was genuinely impressed with `switch` expressions. Around the same time, I stumbled on a video by expert C# developer and youtuber Tim Corey, who basically said, *"Hey, don't just read—write code, mess it up, fix it, learn and repeat."*  

So, I did just that. And what better way to start than by coding something we all love? **Pizza.** 🍕  

#### The main takeaways: 

Repeat exercises several times, preferably using different approaches.  
Keep it short and sweet—don’t overcomplicate it, make it easy to understand.  
Accept that it won’t be perfect, especially the first time (or second… or third).  

#### **About This Project**  

The original challenge, [*Buying Inventory*](https://csharpplayersguide.com/solutions/4th-edition/buying-inventory), required using `switch statements` or `switch expressions` to check the prices of a small inventory list based on user selection.  

Well I went down a different route and:

- Expanded a simple inventory list into a full restaurant menu.  
- Replaced the list with three dictionaries: one for pizzas, one for extras (toppings), and one for drinks, all paired with prices.  
- Added tax calculations (`9.5%` for food, `22%` for drinks) because, well, even in code, you can’t escape taxes.  
- Improved input handling to prevent the program from having a meltdown when users type nonsense.  

#### **One small technical hiccup…**  
- Pizza prices were stored as `int`, while extras and drink prices were `double`, and tax values were `decimal`.  
- Mixing these is like putting pineapple on pizza — controversial and best avoided. 
- So, I converted everything to `decimal` to keep calculations smooth.  
- Finally, I used `Math.Round` to ensure the final price doesn’t look like some wild stock market number.  

Well thare you have it, a simple C# project. It’s not perfect, but neither are my actual pizza-making skills.
