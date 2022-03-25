using System;
using System.Collections.Generic;
using C2C.CSharpTutorial;

class Program {

  public static ClubMember FindMember(Club club, int id) { 
    // Write a method to find a club member, given an id
    return null;
  }

  public static ClubMember FindMember(Club club, string name) { 
    // Write a method to find a club member, given a name
    return null;
  }

  public static ClubVote FindVoteByName(Club club, string name) { 
    // Write a method to find a club member's vote, given a name
    return null;
  }
  
  public static void Main (string[] args) {
    
    Club club1 = new Club();
    club1.Members.Add(new ClubMember(1, "Alice", 12, "blue"));
    club1.Members.Add(new ClubMember(2, "Beth", 11, "orange"));
    club1.Members.Add(new ClubMember(3, "Claire", 10, "red"));
    club1.Members.Add(new ClubMember(4, "Dana", 11, "blue"));
    club1.Members.Add(new ClubMember(5, "Elisa", 10, "purple"));
    club1.Members.Add(new ClubMember(6, "Fran", 9, "yellow"));
    club1.Members.Add(new ClubMember(7, "Georgia", 12, "green"));
    club1.Members.Add(new ClubMember(8, "Hannah", 10, null));
    
    club1.Votes.Add(new ClubVote(1, 1));
    club1.Votes.Add(new ClubVote(2, 1));
    club1.Votes.Add(new ClubVote(3, 1));
    club1.Votes.Add(new ClubVote(4, 2));
    club1.Votes.Add(new ClubVote(5, 4));
    club1.Votes.Add(new ClubVote(6, 4));
    club1.Votes.Add(new ClubVote(8, 1));
    
    Console.WriteLine("1. Who is club member #5?");
    
    Console.WriteLine("2. What is club member #5's favorite color?");

    Console.WriteLine("3. Whose favorite color is blue?");
    
    Console.WriteLine("4. Who doesn't have a favorite color?");

    Console.WriteLine("5. How many club members are there?");
    
    Console.WriteLine("6. How many club members are in 10th grade?");
    
    Console.WriteLine("7. Who did club member #6 vote for?");
    
    Console.WriteLine("8. Who did Beth vote for?");
    
    Console.WriteLine("9. Who voted for Beth?");
    
    Console.WriteLine("10. Who voted for themselves?");
    
    Console.WriteLine("11. Who didn't vote?");
    
    Console.WriteLine("12. What are the election results?");
    
    Console.WriteLine("13. Who won the election?");
    
    Console.WriteLine("14. Add a club member named Isabel with id 9 in grade 8 whose favorite color is purple.");
    
    Console.WriteLine("15. Record that Isabel voted for Beth.");
    
    Console.WriteLine("16. Change Isabel's vote to be for Dana.");
    
    Console.WriteLine("17. Remove Isabel's vote.");    
  }
}