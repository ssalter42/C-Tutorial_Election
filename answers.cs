/*
using System;
using System.Collections.Generic;
using C2C.CSharpTutorial;

class Program {

  public static ClubMember FindMember(Club club, int id) { 
    foreach(ClubMember m in club.Members) {
      if(m.Id == id) {
        return m;
      }
    }
    return null;
  }

  public static ClubMember FindMember(Club club, string name) { 
    foreach(ClubMember m in club.Members) {
      if(m.Name == name) {
        return m;
      }
    }
    return null;
  }

  public static ClubVote FindVoteByName(Club club, string name) { 
    ClubMember voter = FindMember(club, name);
    foreach(ClubVote v in club.Votes) {
      if(v.VoterId == voter.Id) {
        return v;
      }
    }
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
    Console.WriteLine(FindMember(club1, 5).Name);
    
    Console.WriteLine("2. What is club member #5's favorite color?");
    Console.WriteLine(FindMember(club1, 5).FavoriteColor);

    Console.WriteLine("3. Whose favorite color is blue?");
    foreach(ClubMember m in club1.Members) {
      if(m.FavoriteColor == "blue") {
        Console.WriteLine(m.Name);
      }
    }
    
    Console.WriteLine("4. Who doesn't have a favorite color?");
    foreach(ClubMember m in club1.Members) {
      if(m.FavoriteColor == null) {
        Console.WriteLine(m.Name);
      }
    }
       
    Console.WriteLine("5. How many club members are there?");
    Console.WriteLine(club1.Members.Count);
    
    Console.WriteLine("6. How many club members are in 10th grade?");
    int count = 0;
    foreach(ClubMember m in club1.Members) {
      if(m.Grade == 10) {
        count++;
      }
    }
    Console.WriteLine(count);
    
    Console.WriteLine("7. Who did club member #6 vote for?");
    foreach(ClubVote v in club1.Votes) {
      if(v.VoterId == 6) {
        Console.WriteLine(FindMember(club1, v.CandidateId).Name);
      }
    }
    
    Console.WriteLine("8. Who did Beth vote for?");
    ClubVote bethVote = FindVoteByName(club1, "Beth");
    Console.WriteLine(FindMember(club1, bethVote.CandidateId).Name);

    Console.WriteLine("9. Who voted for Beth?");
    foreach(ClubVote v in club1.Votes) {
      if(v.CandidateId == FindMember(club1, "Beth").Id) {
        Console.WriteLine(FindMember(club1, v.VoterId).Name);
      }
    }
    
    Console.WriteLine("10. Who voted for themselves?");
    foreach(ClubVote v in club1.Votes) {
      if(v.CandidateId == v.VoterId) {
        Console.WriteLine(FindMember(club1, v.VoterId).Name);
      }
    }
    
    Console.WriteLine("11. Who didn't vote?");
    foreach(ClubMember m in club1.Members) {
      bool matchFound = false;
      foreach(ClubVote v in club1.Votes) {
        if(v.VoterId == m.Id) {
          matchFound = true;
        }
      }        
      if(matchFound == false) {
        Console.WriteLine(m.Name);
      }
    }

    Console.WriteLine("12. What are the election results?");
    Dictionary<string, int> VoteTotals = new Dictionary<string, int>();
    foreach(ClubVote v in club1.Votes) {
      string candidateName = FindMember(club1, v.CandidateId).Name;
      if(!VoteTotals.ContainsKey(candidateName)) {
        VoteTotals.Add(candidateName, 1);
      } else {
        VoteTotals[candidateName]++;
      }
    }
    
    foreach(string k in VoteTotals.Keys) {
      Console.WriteLine(k + " : " + VoteTotals[k]);
    }
    
    Console.WriteLine("13. Who won the election?");
    string winner = "";
    int maxVotes = 0;
    foreach(string k in VoteTotals.Keys) {
      if(VoteTotals[k] > maxVotes) {
        winner = k;
        maxVotes = VoteTotals[k];
      } else if(VoteTotals[k] == maxVotes) {
        winner += ", " + k;
      }
    }
    Console.WriteLine(winner);
    
    Console.WriteLine("14. Add a club member named Isabel with id 9 in grade 8 whose favorite color is purple.");
    club1.Members.Add(new ClubMember(9, "Isabel", 8, "purple"));
    
    Console.WriteLine("15. Record that Isabel voted for Beth.");
    int bethId = 0;
    foreach(ClubMember m in club1.Members) {
      if(m.Name == "Beth") {
        bethId = m.Id;
      }
    }
    club1.Votes.Add(new ClubVote(9, bethId));

    Console.WriteLine("16. Change Isabel's vote to be for Dana.");
    int danaId = 0;
    foreach(ClubMember m in club1.Members) {
      if(m.Name == "Dana") {
        bethId = m.Id;
      }
    }
    foreach(ClubVote v in club1.Votes) {
      if(v.VoterId == 9) {
        v.CandidateId = danaId;
      }
    }

    Console.WriteLine("17. Remove Isabel's vote.");
    ClubVote isabelVote = null;
    foreach(ClubVote v in club1.Votes) {
      if(v.VoterId == 9) {
        isabelVote = v;
      }
    }
    club1.Votes.Remove(isabelVote);
  }
}
*/