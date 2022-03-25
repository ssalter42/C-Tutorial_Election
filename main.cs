using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    Club club1 = new Club();

    /* 1. Who is club member #5? */
    foreach(ClubMember m in club1.Members) {
      if(m.Id == 5) {
        Console.WriteLine(m.Name);
      }
    }
    /* or */
    Console.WriteLine(club1.Members.FirstOrDefault(m => m.Id == 5).Name);
    
    /* 2. What is club member #5's favorite color? */
    foreach(ClubMember m in club1.Members) {
      if(m.Id == 5) {
        Console.WriteLine(m.FavoriteColor);
      }
    }
    /* or */
    Console.WriteLine(club1.Members.FirstOrDefault(m => m.Id == 5).FavoriteColor);

    /* 3. Whose favorite color is blue? */
    foreach(ClubMember m in club1.Members) {
      if(m.FavoriteColor == "blue") {
        Console.WriteLine(m.Name);
      }
    }
    /* or */
    foreach(ClubMember m in club1.Members.Where(m => m.FavoriteColor == "blue")) {
      Console.WriteLine(m.Name);
    }

    /* 4. Who doesn't have a favorite color? */
    foreach(ClubMember m in club1.Members) {
      if(m.FavoriteColor == null) {
        Console.WriteLine(m.Name);
      }
    }
    /* or */
    foreach(ClubMember m in club1.Members.Where(m => m.FavoriteColor == null)) {
      Console.WriteLine(m.Name);
    }
    
    /* 5. How many club members are there? */
    Console.WriteLine(club1.Members.Count);
    
    /* 6. How many club members are in 10th grade? */
    int count = 0;
    foreach(ClubMember m in club1.Members) {
      if(m.Grade == 10) {
        count++;
      }
    }
    Console.WriteLine(count);
    /* or */
    Console.WriteLine(club1.Members.Count(m => m.Grade == 10));
    
    /* 7. Who did club member #6 vote for? */
    {
      int candidateId = 0;
      foreach(ClubVote v in club1.Votes) {
        if(v.VoterId == 6) {
          candidateId = v.CandidateId;
        }
      }
      foreach(ClubMember m in club1.Members) {
        if(m.Id == candidateId) {
          Console.WriteLine(m.Name);
        }
      }
    }
    /* or */
    Console.WriteLine(club1.Members.FirstOrDefault(m => m.Id == club1.Votes.FirstOrDefault(v => v.VoterId == 6).CandidateId).Name);

    /* 8. Who did Beth vote for? */
    {
      int voterId = 0;
      foreach(ClubMember m in club1.Members) {
        if(m.Name == "Beth") {
          voterId = m.Id;
        }
      }
      int candidateId = 0;
      foreach(ClubVote v in club1.Votes) {
        if(v.VoterId == voterId) {
          candidateId = v.CandidateId;
        }
      }
      foreach(ClubMember m in club1.Members) {
        if(m.Id == candidateId) {
          Console.WriteLine(m.Name);
        }
      }
    }
    /* or */
    Console.WriteLine(club1.Members.FirstOrDefault(m => m.Id == club1.Votes.FirstOrDefault(v => v.VoterId == club1.Members.FirstOrDefault(m => m.Name == "Beth").Id).CandidateId).Name);

    /* 9. Who voted for Beth? */
    {
      int candidateId = 0;
      foreach(ClubMember m in club1.Members) {
        if(m.Name == "Beth") {
          candidateId = m.Id;
        }
      }
      int voterId = 0;
      foreach(ClubVote v in club1.Votes) {
        if(v.CandidateId == candidateId) {
          voterId = v.VoterId;
        }
      }
      foreach(ClubMember m in club1.Members) {
        if(m.Id == voterId) {
          Console.WriteLine(m.Name);
        }
      }
    }
    /* or */
    Console.WriteLine(club1.Members.FirstOrDefault(m => m.Id == club1.Votes.FirstOrDefault(v => v.CandidateId == club1.Members.FirstOrDefault(m => m.Name == "Beth").Id).VoterId).Name);
    
    /* 10. Who voted for themselves? */
    {
      int voterId = 0;
      foreach(ClubVote v in club1.Votes) {
        if(v.CandidateId == v.VoterId) {
          voterId = v.VoterId;
        }
      }
      foreach(ClubMember m in club1.Members) {
        if(m.Id == voterId) {
          Console.WriteLine(m.Name);
        }
      }
    }
    /* or */
    foreach(ClubVote v in club1.Votes.Where(v => v.CandidateId == v.VoterId)) {
      Console.WriteLine(club1.Members.FirstOrDefault(m => v.VoterId == m.Id).Name);
    }
    
    /* 11. Who didn't vote? */
    {
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
    }
    /* or */
    foreach(ClubMember m in club1.Members.Where(m => !club1.Votes.Exists(v => v.VoterId == m.Id))){ 
      Console.WriteLine(m.Name);
    }

    /* 12. What are the election results? */
    Dictionary<string, int> VoteTotals = new Dictionary<string, int>();
    foreach(ClubVote v in club1.Votes) {
      string candidateName = "";
      foreach(ClubMember m in club1.Members) {
        if(v.CandidateId == m.Id) {
          candidateName = m.Name;
        }
      }
      if(!VoteTotals.Keys.Contains(candidateName)) {
        VoteTotals.Add(candidateName, 1);
      } else {
        VoteTotals[candidateName]++;
      }
    }
    
    foreach(string k in VoteTotals.Keys) {
      Console.WriteLine(k + " : " + VoteTotals[k]);
    }
    
    /* 13. Who won the election? */
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
    
    /* 14. Add a club member named Isabel with id 9 in grade 8 whose favorite color is purple. */
    club1.Members.Add(new ClubMember(9, "Isabel", 8, "purple"));
    
    /* 15. Record that Isabel voted for Beth. */
    int bethId = 0;
    foreach(ClubMember m in club1.Members) {
      if(m.Name == "Beth") {
        bethId = m.Id;
      }
    }
    club1.Votes.Add(new ClubVote(9, bethId));

    /* 16. Change Isabel's vote to be for Dana. */
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

    /* 17. Remove Isabel's vote. */
    ClubVote isabelVote = null;
    foreach(ClubVote v in club1.Votes) {
      if(v.VoterId == 9) {
        isabelVote = v;
      }
    }
    club1.Votes.Remove(isabelVote);
  }
}

public class Club {
  public List<ClubMember> Members = new List<ClubMember>();
  public List<ClubVote> Votes = new List<ClubVote>();

  public Club() {
      Members.Add(new ClubMember(1, "Alice", 12, "blue"));
      Members.Add(new ClubMember(2, "Beth", 11, "orange"));
      Members.Add(new ClubMember(3, "Claire", 10, "red"));
      Members.Add(new ClubMember(4, "Dana", 11, "blue"));
      Members.Add(new ClubMember(5, "Elisa", 10, "purple"));
      Members.Add(new ClubMember(6, "Fran", 9, "yellow"));
      Members.Add(new ClubMember(7, "Georgia", 12, "green"));
      Members.Add(new ClubMember(8, "Hannah", 10, null));
      
      Votes.Add(new ClubVote(1, 1));
      Votes.Add(new ClubVote(2, 1));
      Votes.Add(new ClubVote(3, 1));
      Votes.Add(new ClubVote(4, 2));
      Votes.Add(new ClubVote(5, 4));
      Votes.Add(new ClubVote(6, 4));
      Votes.Add(new ClubVote(8, 1));
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

public class ClubVote {
  public ClubVote(int voterId, int candidateId) {
    VoterId = voterId;
    CandidateId = candidateId;
  }
    
  public int VoterId { get; set; }
  public int CandidateId { get; set; }
}