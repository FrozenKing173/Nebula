public class Program
{
    /// <summary>
    /// You are probably familiar with social media "like" systems. People can like posts and the UI displays who likes certain posts. Write a method that takes in a list of names and produces the format below:
    /// Likes(new List<string>()) => "no one likes this"
    /// Likes(new List<string> {"Peter"}) => "Peter likes this"
    /// Likes(new List<string> {"Jacob", "Alex"}) => "Jacob and Alex like this"
    /// Likes(new List<string> {"Max", "John", "Mark"}) => "Max, John and Mark like this"
    /// Likes(new List<string> {"Alex", "Jacob", "Mark", "Max"}) => "Alex, Jacob and 2 others like this"
    /// Note: if the amount of people who like something is 4 or more, print out the first 2 names following by how many others like it.
    /// </summary>
    public string Likes(IList<string> listOfLikes)
    {
        // IF listOfLikes IS 4 items OR more THEN Print out the first 2 names following by how many others like it.
        // ELSE IF listOfLikes IS 3 items OR less THEN Print out each name ending with 'like this'
        
        int listLength = listOfLikes.Count;

        if (listLength >= 4)
        {
            return listOfLikes[0] + ", " + listOfLikes[1] + " and " + (listOfLikes.Count - 2) + " others like this";
        }
        else if (listLength == 3)
        {
            return listOfLikes[0] + ", " + listOfLikes[1] + " and " + listOfLikes[2] + " like this";
        }
        else if (listLength == 2)
        {
            return listOfLikes[0] + " and " + listOfLikes[1] + " like this";
        }
        else
        {
            return listOfLikes[0] + " like this";
        }
    }
}