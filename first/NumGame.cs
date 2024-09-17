namespace first;

public class NumGame
{
  private int _maxNum;
  private Random _random;


  private int _tryCount;


  public NumGame(int maxNum = 100)
  {
    _maxNum = maxNum;
    _random = new Random();
  }
   
  internal void StartGame(){
    int randomNum = _random.Next(_maxNum);
    int userNum = 0;
    
    while (randomNum != userNum)
    {
      if(!GetUserNum(ref userNum)){
        Console.WriteLine("Incorect value, enter only int!");
        continue;    
      }
      Console.WriteLine(GetAnswer(userNum, randomNum));
    }

    Console.WriteLine($"Player score: {_tryCount}");
  }

  private string GetAnswer(int userNum, int randomNum){
    _tryCount++;
    if(userNum < randomNum)
      return "Num is greater";
    else if(userNum > randomNum)
      return "Num is less";
    return "U win";
  }

  private bool GetUserNum(ref int o){
    string input = Console.ReadLine();
    bool isParsed = Int32.TryParse(input, out o);
    return isParsed;
  }
    
}

