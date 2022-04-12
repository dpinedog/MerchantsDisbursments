The solution is not completed, only indicated. Requests returns dummy results. 
It is implemented in C# NET Core 3.1 (it's a modern language and easy to understand)
You can download the solution compile it in Visual Studio and run on it. Also you can deploy it in a Web Server.

The application has two paths for different requests

api/v1/UpdateDisbursmentsPerMerchant --> It should read the files in JSON format, calculte the disbursed money for a merchant each week and write it in a JSON file (I now it would be better to do it in a Database). The response to this request is inmediate, and throws a background thread who does the work

api/v1/DisbursmentsPerMerchantAWeek --> Returns the disbursment of a merchant in a  given week (reads it from the file generated in the previous request). The request receives the Merchant ID and the first day of the week (in numeric format). If no Merchant and no week are specified returns all the Disbursements for each Merchant

I now it would be better to have a Database and a logger system, and protect the requests with token... 
