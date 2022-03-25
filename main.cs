using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    Club club1 = new Club();

    /* 1. Who is club member #5? */
    Console.Write("hello");
    /* 2. What is club member #5's favorite color? */
    /* 3. Whose favorite color is blue? */
    /* 4. Who doesn't have a favorite color? */
    /* 5. How many club members are there? */
    /* 6. How many club members are in 10th grade? */
    /* 7. Who did club member #6 vote for? */
    /* 8. Who did Beth vote for? */
    /* 9. Who voted for Beth? */
    /* 10. Who voted for themselves? */
    /* 11. Who didnt vote? */
    /* 12. What are the election results for President? */
    /* 13. Extra Credit: Who won the election for President? */
    /* Write the following changes in SQL: */
    /* 14. Add a club member named Isabel with id 9 in grade 8 whose favorite color is purple. */
    /* 15. Record that Isabel voted for Beth. */
    /* 16. Change Isabel's vote to be for Dana. */
    /* 17. Remove Isabel's vote. */
  }
}

public class Club {
  public List<ClubMember> Members = new List<ClubMember>();

  public Club() {
      Members.Add(new ClubMember(1, "Alice", 12, "blue"));
      Members.Add(new ClubMember(2, "Beth", 11, "orange"));
      Members.Add(new ClubMember(3, "Claire", 10, "red"));
      Members.Add(new ClubMember(4, "Dana", 11, "blue"));
      Members.Add(new ClubMember(5, "Elisa", 10, "purple"));
      Members.Add(new ClubMember(6, "Fran", 9, "yellow"));
      Members.Add(new ClubMember(7, "Georgia", 12, "green"));
      Members.Add(new ClubMember(8, "Hannah", 10, null));
  }
}

public class ClubMember {

  public ClubMember(int id, string name, int grade, string color) {
    Id = id;
    Name = name;
    Grade = grade;
    FavoriteColor = color;
  }
  
  public int Id { get; set; }
  public string Name  { get; set; }
  public int Grade  { get; set; }
  public string FavoriteColor  { get; set; }
}

public class Vote {
  public Vote(int voterId, int candidateId) {
    VoterId = voterId;
    CandidateId = candidateId;
  }
    
  public int VoterId { get; set; }
  public int CandidateId { get; set; }
}